namespace CameraReview.Product.Camera
{
    public interface ICamera : IProducts
    {
        public int MaxISO { get; set; }
        public string Type {  get; set; }
        public int CropFactor { get; set; }
        public int MaxResolution { get; set; }
        public int MaxZoom { get; set; }

    }
}
