namespace CameraReview.Product.Camera
{
    public class Camera : ICamera
    {
        public string? Id { get; set; }
        public int MaxISO { get; set; }
        public string Type { get; set; }
        public int CropFactor { get; set; }
        public int MaxResolution { get; set; }
        public int MaxZoom { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Manufacturer { get; set; }
        public List<Feature> Features { get; set; }

    public string GetContent()
        {
            return $"Name: {this.Name}\n Type:{this.Type}\n CropFactor: {this.CropFactor}";
        }
    }
}
