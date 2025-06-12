using Microsoft.Extensions.Options;
using Shiftly.API.Settings;

public class MongoService
{
	private readonly IMongoDatabase _database;

	public MongoService(IOptions<MongoDbSettings> settings)
	{
		var client = new MongoClient(settings.Value.ConnectionString);
		_database = client.GetDatabase(settings.Value.DatabaseName);
	}
}
