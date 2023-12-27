namespace CameraReview.Product
{
    public interface IProducts
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? SKU { get; set; }
        public string? Manufacturer {  get; set; }
        public List<Feature>? Features { get; set; }
        public string GetContent();

    }
}
