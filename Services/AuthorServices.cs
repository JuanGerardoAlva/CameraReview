using CameraReview.Authors;
using CameraReview.Models;
using CameraReview.Review;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.Services
{
    public class AuthorServices
    {
        private readonly IMongoCollection<Author> _authorCollection;
        public AuthorServices(IOptions<ProductDataBaseSettings> authorServices)
        {
            var mongoClient = new MongoClient(authorServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(authorServices.Value.DatabaseName);

            _authorCollection = mongoDatabase.GetCollection<Author>(authorServices.Value.ProductCollectionName);
        }
        public async Task<List<Author>> GetAsync() =>
          await _authorCollection.Find(x => true).ToListAsync();

        public async Task<Author> GetAsync(string id) =>
           await _authorCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Author authors) =>
           await _authorCollection.InsertOneAsync(authors);

        public async Task UpdateAsync(string id, Author authors) =>
           await _authorCollection.ReplaceOneAsync(x => x.Id == id, authors);

        public async Task RemoveAsync(string id, Author authors) =>
           await _authorCollection.DeleteOneAsync(x => x.Id == id);

    }
}

