using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace CameraReview.Product.Camera
{

    [BsonIgnoreExtraElements]
    public class Camera : ICamera
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        
        [BsonElement("MaxISO")]
        public int MaxISO { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("CropFactor")]
        public int CropFactor { get; set; }

        [BsonElement("MaxResolution")]
        public int MaxResolution { get; set; }

        [BsonElement("MaxZoom")]
        public int MaxZoom { get; set; }

        [BsonElement("Name")]
        public string? Name { get; set; }

        [BsonElement("SKU")]
        public string? SKU { get; set; }

        [BsonElement("Manufacturer")]
        public string? Manufacturer { get; set; }

        [DataMember]
        //[BsonElement("Features")]
        public List<Feature>? Features { get; set; }

    public string GetContent()
        {
            return $"Name: {this.Name}\n Type:{this.Type}\n CropFactor: {this.CropFactor}";
        }
    }
}
