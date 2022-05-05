using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Number")]
        public int Number { get; set; }
    }
}
