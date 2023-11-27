using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CameraReview.Product
{
    public class Products : IProduct
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("SKU")]
        public string SKU { get; set; }

        [BsonElement("Manufacturer")]
        public string Manufacturer { get; set; }

        [BsonElement("Features")]
        public List<Feature> Features { get; set; }

        public string GetContent()
        {
            return $"Name: {Name} \n SKU: {SKU} \n Manufacturer: {Manufacturer}";
        }
    }
}
