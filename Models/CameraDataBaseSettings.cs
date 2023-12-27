namespace CameraReview.Models
{
    public class CameraDataBaseSettings : ICameraDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? CameraCollectionName { get; set; }
    }
}
