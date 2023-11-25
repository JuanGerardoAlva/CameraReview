﻿using CameraReview.Product;

namespace CameraReview.Review
{
    public class Review : IReview
    {
        public string? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public IProduct Product { get; set; }
    }
}