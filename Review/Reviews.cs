using CameraReview.Product;
using CameraReview.Review;
using MongoDB.Bson.Serialization.Attributes;

namespace CameraReview.Review
{
    public class Reviews : IReview
    {
       // [BsonId]
       // [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

       
        public string Title { get; set; }

      //  [BsonElement("Content")]
        public string Content { get; set; }

      //  [BsonElement("Author")]
        public string Author { get; set; }

     
        public IProduct Products { get; set; }
    }
}
