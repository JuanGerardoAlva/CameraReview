using MongoDB.Bson.Serialization.Attributes;

namespace CameraReview.Authors

{
    [BsonIgnoreExtraElements]
    public class Author:IAuthor
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string? Name { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Occupation")]
        public string? Occupation { get; set; }

    }
}
