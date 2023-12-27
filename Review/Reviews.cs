using CameraReview.Authors;
using CameraReview.Product;
using CameraReview.Review;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System.Security.Cryptography.X509Certificates;

namespace CameraReview.Review
{
    [BsonIgnoreExtraElements]
    public class Reviews : IReview
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Title")]
        public string? Title { get; set; }

        [BsonElement("Content")]
        public string? Content { get; set; }

        [BsonElement("Author")]
        public string? Author { get; set; }

        [BsonIgnoreIfNull]
        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<IProducts, Products>))]
        public IProducts? Products { get; set; }

    }
}
