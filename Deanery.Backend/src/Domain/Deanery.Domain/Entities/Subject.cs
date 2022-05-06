using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Deanery.Domain.Entities
{
    public class Subject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("LessonType")]
        public LessonType LessonType { get; set; }

        public virtual Teacher Teacher { get; set; }

        [BsonElement("TeacherId")]
        public int TeacherId { get; set; }

        public virtual Cathedra Cathedra { get; set; }

        [BsonElement("CathedraId")]
        public int CathedraId { get; set; }

        [BsonElement("Groups")]
        public IEnumerable<Group> Groups { get; set; }
    }
}