namespace CameraReview.Product.Lens
{
    public class Lens : ILens
    {
        public string? Id { get; set; }
        public int FocalLength { get; set; }
        public int ApertureLens { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Manufacturer { get; set; }
        public List<Feature> Features { get; set; }

        public string GetContent()
        {
            return $"Name: {Name}\n SKU: {SKU}\n Manufacturer: {Manufacturer}";
        }
    }
}
