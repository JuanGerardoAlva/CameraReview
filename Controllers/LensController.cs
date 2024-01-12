using CameraReview.Product.Camera;
using CameraReview.Product.Lens;
using CameraReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LensController : Controller
    {
        private readonly LensServices _lensServices;
        public LensController(LensServices lensServices)
        {
            _lensServices = lensServices;
        }

        [HttpGet]
        public async Task<List<Lens>> GetLens()
            => await _lensServices.GetAsync();

        [HttpPost]
        public async Task<Lens> PostLens(Lens lens)
        {
            await _lensServices.CreateAsync(lens);

            return lens;
        }

        [HttpPut]
        public async Task<Lens> PutLens(string id, Lens lens)
        {
            await _lensServices.UpdateAsync(id, lens);

            return lens;
        }

        [HttpDelete]
        public async Task<Lens> DeleteLens(string id, Lens lens)
        {
            await _lensServices.RemoveAsync(id, lens);  
            
            return lens;

        }
    }
}

