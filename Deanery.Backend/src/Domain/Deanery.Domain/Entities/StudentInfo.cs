using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class StudentInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Patronomyc")]
        public string Patronomyc { get; set; }

        [BsonElement("DateOfBirth")]
        public BsonDateTime DateOfBirth { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
