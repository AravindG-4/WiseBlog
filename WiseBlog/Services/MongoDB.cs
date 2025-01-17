using MongoDB.Driver;
using WiseBlog.Shared.Models;
using Microsoft.JSInterop;
namespace WiseBlog.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Profile> _profileCollection;
        //public readonly Supabase.Client _supabaseClient;
        //private readonly Secrets _secrets = new Secrets();
        public readonly IJSRuntime _jsruntime;

        public MongoDBService(IConfiguration configuration, IJSRuntime jsruntime)
        {
            var MongoUrl = configuration["MongoDB:URL"];
            var DatabaseName = configuration["MongoDB:DBNAME"];
            var ProfileCollectionName = configuration["MongoDB:PROFILE:COLLECTION"];

            //_supabaseClient = supabaseClient;
            _jsruntime = jsruntime;


            Console.WriteLine("Making Connection: "+ MongoUrl);
            var client = new MongoClient("mongodb+srv://AravindG:Aravind#4@blazordb.kdp3k.mongodb.net/?retryWrites=true&w=majority&appName=BlazorDB");
            Console.WriteLine("Connection string works");
            var database = client.GetDatabase(DatabaseName);
            Console.WriteLine("Database got");
            _profileCollection = database.GetCollection<Profile>(ProfileCollectionName);
            Console.WriteLine("Collection got");
        }


        public async Task<Profile> RegisterProfile(string ID, string bio, byte[] img)
        {
            var profile = new Profile
            {
                userId = ID,
                bio = bio,
                image = img,
                following = new List<string>(),
                followers = new List<string>()
            };
            await _profileCollection.InsertOneAsync(profile);
            var filter = Builders<Profile>.Filter.Eq(task => task.userId, ID);
            var inserted = _profileCollection.Find(filter).FirstOrDefault();
            return inserted;
        }

        //public async Task<List<User>> ReadCompleted()
        //{
        //    var Tasks = await _userCollection.Find(task => task.Completed == true).ToListAsync();
        //    return Tasks;
        //}

        //public async Task CreateToDo(User task)
        //{
        //    await _userCollection.InsertOneAsync(task);
        //}

        //public async Task CompleteToDo(User task)
        //{
        //    var id = task.Id;
        //    var filter = Builders<User>.Filter.Eq(task => task.Id, id);
        //    var update = Builders<User>.Update.Set(task => task.Completed, true);

        //    await _userCollection.UpdateOneAsync(filter, update);
        //}

        //public async Task RemoveToDo(User task)
        //{
        //    var id = task.Id;
        //    var filter = Builders<User>.Filter.Eq(task => task.Id, id);
        //    await _userCollection.DeleteOneAsync(filter);
        //}
    }
}
