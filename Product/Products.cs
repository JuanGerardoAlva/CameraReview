namespace CameraReview.Product
{
    public class Products : IProduct
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Manufacturer { get; set; }
        public List<Feature> Features { get; set; }

        public string GetContent()
        {
            return $"Name: {Name} \n SKU: {SKU} \n Manufacturer: {Manufacturer}";
        }
    }
}
