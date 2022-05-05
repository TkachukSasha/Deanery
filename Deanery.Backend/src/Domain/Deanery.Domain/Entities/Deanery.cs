using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Deanery
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        public virtual Audience Audience { get; set; }

        [BsonElement("AudienceId")]
        public int AudienceId { get; set; }
    }
}
