namespace CameraReview.Models
{
    public interface IReviewDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? ReviewCollectionName { get; set; }
    }
}
