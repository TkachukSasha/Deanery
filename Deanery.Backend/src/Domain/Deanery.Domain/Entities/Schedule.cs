using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Schedule
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("StartOfLesson")]
        public BsonDateTime StartOfLesson { get; set; }

        public virtual Cathedra Cathedra { get; set; }

        public virtual Course Course { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Group Group { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Audience Audience { get; set; }

        [BsonElement("CathedraId")]
        public int CathedraId { get; set; }

        [BsonElement("CourseId")]
        public int CourseId { get; set; }

        [BsonElement("SubjectId")]
        public int SubjectId { get; set; }

        [BsonElement("GroupId")]
        public int GroupId { get; set; }

        [BsonElement("TeacherId")]
        public int TeacherId { get; set; }

        [BsonElement("AudienceId")]
        public int AudienceId { get; set; }
    }
}
