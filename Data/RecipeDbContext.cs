using MongoDB.Driver;
using RecipeAPI.Models;
namespace RecipeAPI.Data
{
    public class RecipeDbContext
    {
        private readonly IMongoDatabase _database;
        public RecipeDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public IMongoCollection<Recipe> Recipes => _database.GetCollection<Recipe>("Recipes");
        public IMongoCollection<Ingredient> Ingredients => _database.GetCollection<Ingredient>("Ingredients");
    }
}
