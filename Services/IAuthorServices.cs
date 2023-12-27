using CameraReview.Authors;

namespace CameraReview.Services
{
    public interface IAuthorServices
    {
        Task<List<Author>> GetAsync();
        Task<Author> GetAsync(string id);

        Task CreateAsync(Author authors);

        Task UpdateAsync(string id, Author authors);

        Task RemoveAsync(string id, Author authors);
    }
}
