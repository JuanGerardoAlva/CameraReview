namespace CameraReview.Product.Lens
{
    public interface ILens:IProducts
    {
        public int FocalLength { get; set; }
        public int ApertureLens { get; set; }

    }
}
