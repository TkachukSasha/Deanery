using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Surname")]
        public string Surname { get; set; }

        [BsonElement("Patronomyc")]
        public string Patronomyc { get; set; }

        public virtual Cathedra Cathedra{ get; set; }

        [BsonElement("CathedraId")]
        public int CathedraId { get; set; }

        public virtual Subject Subject { get; set; }

        [BsonElement("SubjectId")]
        public int SubjectId { get; set; }
    }
}