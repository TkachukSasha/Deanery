using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Deanery.Domain.Entities
{
    public class RecordBook
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("EducationForm")]
        public EducationForm EducationForm { get; set; }

        public virtual Student Student { get; set; }

        [BsonElement("StudentId")]
        public int StudentId { get; set; }

        [BsonElement("Subjects")]
        public IEnumerable<Subject> Subjects { get; set; }

        [BsonElement("Marks")]
        public IEnumerable<int> Marks { get; set; }
    }
}
