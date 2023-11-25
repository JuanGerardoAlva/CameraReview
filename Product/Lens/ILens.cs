namespace CameraReview.Product.Lens
{
    public interface ILens:IProduct
    {
        public string? Id { get; set; }
        public int FocalLength { get; set; }
        public int ApertureLens { get; set; }

    }
}
