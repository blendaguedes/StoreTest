using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StoreTest.Models
{
    public class Store
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Item")]
        public string Item { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
