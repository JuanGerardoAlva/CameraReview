namespace CameraReview.Models
{
    public interface ICameraDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? CameraCollectionName { get; set; }
    }
}
