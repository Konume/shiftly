using Microsoft.Extensions.Options;
using Shiftly.API.Settings;
using MongoDB.Driver;
namespace Shiftly.API.Settings
{

	public class MongoDbSettings
	{
		public string ConnectionString { get; set; } = null!;
		public string DatabaseName { get; set; } = null!;
	}


	public class MongoService
	{
		private readonly IMongoDatabase _database;

		public MongoService(IOptions<MongoDbSettings> settings)
		{
			var client = new MongoClient(settings.Value.ConnectionString);
			_database = client.GetDatabase(settings.Value.DatabaseName);
		}
	}
}

	
