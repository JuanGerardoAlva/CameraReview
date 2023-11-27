using CameraReview.Product;

namespace CameraReview.Review
{
    public interface IReview
    {
        public string? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public IProduct Products { get; set; }
    }
}
