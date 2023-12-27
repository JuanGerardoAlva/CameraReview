namespace CameraReview.Models
{
    public class LensDataBaseSettings : ILensDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? LensCollectionName { get; set; }
    }
}
