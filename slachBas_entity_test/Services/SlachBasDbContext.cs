using System.Configuration;
using MongoDB.Driver;
using slachBas_entity_test.Entities;

namespace slachBas_entity_test.Services
{
    public class SlachBasDbContext
    {
        private readonly IMongoDatabase _database;

        public SlachBasDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MongoDbConnectionString"].ConnectionString;
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("slachBasDb");
        }

        public IMongoCollection<Avatar> Avatars => _database.GetCollection<Avatar>("avatars");
    }
}