using CameraReview.Review;

namespace CameraReview.Services
{
    public interface IReviewServices
    {
        Task<List<Reviews>> GetAsync();

        Task<Reviews> GetAsync(string id);

        Task CreateAsync(Reviews reviews);

        Task UpdateAsync(string id, Reviews reviews);

        Task RemoveAsync(string id, Reviews reviews);
    }
}
