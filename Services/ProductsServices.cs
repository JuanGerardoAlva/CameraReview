using CameraReview.Models;
using CameraReview.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.Services
{  
    public class ProductsServices: IProductServices
    {
        private readonly IMongoCollection<Products> _productCollection;
               
        public ProductsServices(IOptions<ProductDataBaseSettings> productsServices)
        {
            var mongoClient = new MongoClient(productsServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(productsServices.Value.DatabaseName);

            _productCollection = mongoDatabase.GetCollection<Products>(productsServices.Value.ProductCollectionName);
        }

        public async Task<List<Products>>GetAsync()=>
            await _productCollection.Find(x=>true).ToListAsync();

        public async Task<Products>GetAsync(string id)=>
            await _productCollection.Find(x=>x.Id== id).FirstOrDefaultAsync();

        public async Task CreateAsync(Products products)=>
            await _productCollection.InsertOneAsync(products);

        public async Task UpdateAsync(string id, Products products)=>
            await _productCollection.ReplaceOneAsync(x=>x.Id==id, products);

        public async Task RemoveAsync(string id, Products products)=>
            await _productCollection.DeleteOneAsync(x=>x.Id == id);

    }
}
