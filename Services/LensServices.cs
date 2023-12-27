using CameraReview.Models;
using CameraReview.Product.Camera;
using CameraReview.Product.Lens;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.Services
{
    public class LensServices: ILensServices
    {
        private readonly IMongoCollection<Lens> _lensCollection;

        public LensServices(IOptions<ProductDataBaseSettings> lensServices)
        {
            var mongoClient = new MongoClient(lensServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(lensServices.Value.DatabaseName);

            _lensCollection = mongoDatabase.GetCollection<Lens>(lensServices.Value.ProductCollectionName);
        }

        public async Task<List<Lens>> GetAsync() =>
            await _lensCollection.Find(x => true).ToListAsync();

        public async Task<Lens> GetAsync(string id) =>
            await _lensCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Lens lens) =>
            await _lensCollection.InsertOneAsync(lens);

        public async Task UpdateAsync(string id, Lens lens) =>
            await _lensCollection.ReplaceOneAsync(x => x.Id == id, lens);

        public async Task RemoveAsync(string id, Lens lens) =>
            await _lensCollection.DeleteOneAsync(x => x.Id == id);

    }
}
