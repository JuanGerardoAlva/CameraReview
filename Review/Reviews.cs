using CameraReview.Authors;
using CameraReview.Product;
using CameraReview.Review;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace CameraReview.Review
{
    [BsonIgnoreExtraElements]
    public class Reviews : IReview
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        public IAuthor Author { get; set; }

        //public IProduct Products { get; set; }

    }
}
