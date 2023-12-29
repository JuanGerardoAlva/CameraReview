using CameraReview.Models;
using CameraReview.Product;
using CameraReview.Product.Camera;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.Services
{
    public class CameraServices: ICameraServices
    {
        private readonly IMongoCollection<Camera> _cameraCollection;

        public CameraServices(IOptions<CameraDataBaseSettings> cameraServices)
        {
            var mongoClient = new MongoClient(cameraServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(cameraServices.Value.DatabaseName);

            _cameraCollection = mongoDatabase.GetCollection<Camera>(cameraServices.Value.CameraCollectionName);
        }

        public async Task<List<Camera>> GetAsync() =>
            await _cameraCollection.Find(x => true).ToListAsync();

        public async Task<Camera> GetAsync(string id) =>
            await _cameraCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Camera camera) =>
            await _cameraCollection.InsertOneAsync(camera);

        public async Task UpdateAsync(string id, Camera camera) =>
            await _cameraCollection.ReplaceOneAsync(x => x.Id == id, camera);

        public async Task RemoveAsync(string id, Camera camera) =>
            await _cameraCollection.DeleteOneAsync(x => x.Id == id);

    }
}
