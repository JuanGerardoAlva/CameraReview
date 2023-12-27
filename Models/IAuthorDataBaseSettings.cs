namespace CameraReview.Models
{
    public interface IAuthorDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? AuthorCollectionName { get; set; }

    }
}
