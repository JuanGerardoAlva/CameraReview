using CameraReview.Authors;
using CameraReview.Review;
using CameraReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly AuthorServices _authorServices;
        public AuthorController(AuthorServices authorServices)
        {
            _authorServices = authorServices;
        }

        [HttpGet]
        public async Task<List<Author>> GetAuthor()
            => await _authorServices.GetAsync();


        [HttpPost]
        public async Task<Author> PostAuthor(Author authors)
        {
            await _authorServices.CreateAsync(authors);

            return authors;
        }
    }
}


