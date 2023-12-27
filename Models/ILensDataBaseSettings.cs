namespace CameraReview.Models
{
    public interface ILensDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? LensCollectionName { get; set; }

    }
}
