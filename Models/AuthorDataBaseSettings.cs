namespace CameraReview.Models
{
    public class AuthorDataBaseSettings : IAuthorDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? AuthorCollectionName { get; set; }
    }
}
