﻿using CameraReview.Authors;
using CameraReview.Controllers;
using CameraReview.Product.Camera;
using CameraReview.Review;
using CameraReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly ReviewServices _reviewServices;
        public ReviewController(ReviewServices reviewServices)
        {
            _reviewServices = reviewServices;
        }


        [HttpGet]
        public async Task<List<Reviews>> GetReviews() 
            => await _reviewServices.GetAsync();
       

        [HttpPost]
        public async Task<Reviews> PostReviews(Reviews reviews)
        {
            await _reviewServices.CreateAsync(reviews);

            return reviews;
        }

        [HttpPut("{id}")]

        public async Task<Reviews>  PutReview(string id, Reviews reviews)
        {
            await _reviewServices.UpdateAsync(id, reviews);

            return reviews;
        }

        [HttpDelete("{id}")]

        public async Task<Reviews> DeleteReview(string id, Reviews reviews)
        {
            await _reviewServices.RemoveAsync(id, reviews);

            return reviews;

        }

    }
}

