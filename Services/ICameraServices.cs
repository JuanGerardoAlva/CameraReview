using CameraReview.Product.Camera;

namespace CameraReview.Services
{
    public interface ICameraServices
    {
        Task<List<Camera>> GetAsync();

        Task<Camera> GetAsync(string id);

         Task CreateAsync(Camera camera);

        Task UpdateAsync(string id, Camera camera);

        Task RemoveAsync(string id, Camera camera);
    }
}
