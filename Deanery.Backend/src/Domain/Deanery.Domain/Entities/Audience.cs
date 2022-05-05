using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Audience
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public virtual Cathedra Cathedra { get; set; }

        [BsonElement("CathedraId")]
        public int CathedraId { get; set; }

        [BsonElement("Number")]
        public int Number { get; set; }
    }
}