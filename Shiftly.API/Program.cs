DotNetEnv.Env.Load();
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShiftlyAPI.Repositories;
using ShiftlyAPI.Settings;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja z pliku + zmienne �rodowiskowe
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                      .AddEnvironmentVariables();

// Pobierz po��czenie MongoDB i nazw� bazy danych z konfiguracji
var mongoConnectionString = builder.Configuration["MONGODB_CONNECTIONSTRING"];
var mongoDatabaseName = builder.Configuration["MONGODB_DATABASENAME"];

// Pobierz konfiguracj� MongoDB
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<MongoDbSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});


// Dodanie repozytori�w (mo�esz stworzy� interfejsy i implementacje)
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IShiftRepository, ShiftRepository>();
builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
builder.Services.AddScoped<ISwapRequestRepository, SwapRequestRepository>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();

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

