using CameraReview.Authors;
using CameraReview.Models;
using CameraReview.Product;
using CameraReview.Review;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.Services
{
    public class ReviewServices: IReviewServices
    {
        private readonly IMongoCollection<Reviews> _reviewCollection;
        public ReviewServices(IOptions<ReviewDataBaseSettings> reviewServices)
        {
           var mongoClient = new MongoClient(reviewServices.Value.ConnectionString);
           var mongoDatabase = mongoClient.GetDatabase(reviewServices.Value.DatabaseName);

            _reviewCollection = mongoDatabase.GetCollection<Reviews>(reviewServices.Value.ReviewCollectionName);
       
        }

        public async Task<List<Reviews>> GetAsync() =>
          await _reviewCollection.Find(x => true).ToListAsync();
           
        
        public async Task<Reviews> GetAsync(string id) =>
           await _reviewCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Reviews reviews) =>
           await _reviewCollection.InsertOneAsync(reviews);

        public async Task UpdateAsync(string id, Reviews reviews) =>
           await _reviewCollection.ReplaceOneAsync(x => x.Id == id, reviews);

        public async Task RemoveAsync(string id, Reviews reviews) =>
           await _reviewCollection.DeleteOneAsync(x => x.Id == id);


    }

}
