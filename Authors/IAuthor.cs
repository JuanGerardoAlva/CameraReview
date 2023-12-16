namespace CameraReview.Authors
{
    public interface IAuthor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

    }
}
