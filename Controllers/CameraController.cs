using CameraReview.Product;
using CameraReview.Product.Camera;
using CameraReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : Controller
    {
        private readonly CameraServices _cameraServices;
        public CameraController(CameraServices cameraServices)
        {
            _cameraServices = cameraServices;
        }

        [HttpGet]
        public async Task<List<Camera>> GetCamera()
            => await _cameraServices.GetAsync();

        [HttpPost]
        public async Task<Camera> Camera(Camera camera)
        {
            await _cameraServices.CreateAsync(camera);

            return camera;
        }


    }
}
