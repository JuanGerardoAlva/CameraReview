using CameraReview.Product.Lens;

namespace CameraReview.Services
{
    public interface ILensServices
    {
        Task<List<Lens>> GetAsync();

        Task<Lens> GetAsync(string id);

       Task CreateAsync(Lens lens);

        Task UpdateAsync(string id, Lens lens);

        Task RemoveAsync(string id, Lens lens);
    }
}
