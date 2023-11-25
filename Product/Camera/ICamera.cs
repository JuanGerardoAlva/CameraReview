namespace CameraReview.Product.Camera
{
    public interface ICamera : IProduct
    {
        public string? Id {  get; set; }
        public int MaxISO { get; set; }
        public string Type {  get; set; }
        public int CropFactor { get; set; }
        public int MaxResolution { get; set; }
        public int MaxZoom { get; set; }

    }
}
