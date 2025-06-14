
using Microsoft.Extensions.Options;
using MongoDB.Driver;
//using ShiftlyAPI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DotNetEnv;
using Shiftly.API.Settings;

DotNetEnv.Env.Load();
var builder = WebApplication.CreateBuilder(args);

// Konfiguracja z pliku + zmienne środowiskowe
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                      .AddEnvironmentVariables();

// Pobierz połączenie MongoDB i nazwę bazy danych z konfiguracji
var mongoConnectionString = builder.Configuration["MONGODB_CONNECTIONSTRING"];
var mongoDatabaseName = builder.Configuration["MONGODB_DATABASENAME"];

// Pobierz konfigurację MongoDB
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<MongoDbSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});


// Dodanie repozytoriów (możesz stworzyć interfejsy i implementacje)
//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IShiftRepository, ShiftRepository>();
//builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
//builder.Services.AddScoped<ISwapRequestRepository, SwapRequestRepository>();
//builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
//builder.Services.AddScoped<INotifier, Notifier>();


// Kontrolery + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// (Opcjonalnie) CORS dla React Native
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll"); // CORS
app.UseAuthorization();
app.MapControllers();

app.Run();

