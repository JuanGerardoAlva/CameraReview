﻿namespace CameraReview.Models
{
    public class ProductDataBaseSettings:IProductDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? ProductCollectionName { get; set; }

    }
}
