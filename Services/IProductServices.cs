using CameraReview.Product;

namespace CameraReview.Services
{
    public interface IProductServices
    {
        Task<List<Products>> GetAsync();

        Task<Products> GetAsync(string id);

        Task CreateAsync(Products products);

        Task UpdateAsync(string id, Products products);

        Task RemoveAsync(string id, Products products);
    }
}
