namespace CameraReview.Models
{
    public interface IProductDataBaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? ProductCollectionName { get; set; }

    }
}
