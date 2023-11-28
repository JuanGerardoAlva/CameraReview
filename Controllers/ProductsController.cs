using CameraReview.Product;
using CameraReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraReview.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ProductsServices _productsServices;
        public ProductsController(ProductsServices productsServices) 
        {
            _productsServices = productsServices;
        }

        [HttpGet]
        public async Task<List<Products>>GetProducts()
            => await _productsServices.GetAsync();
        
        [HttpPost]
        public async Task <Products>PostProducts(Products products)
        {
            await _productsServices.CreateAsync(products);

            return products;    
        }


    }
}
