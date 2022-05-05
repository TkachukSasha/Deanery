using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Deanery.Domain.Entities
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("EducationForm")]
        public EducationForm EducationForm { get; set; }

        public virtual RecordBook RecordBook { get; set; }

        [BsonElement("RecordBookId")]
        public int RecordBookId { get; set; }

        [BsonElement("StatusOfEducation")]
        public StatusOfEducation StatusOfEducation { get; set; }

        [BsonElement("StartOfEducation")]
        public int StartOfEducation { get; set; }

        [BsonElement("EndOfEducation")]
        public int EndOfEducation { get; set; }

        public virtual Group Group { get; set; }

        [BsonElement("GroupId")]
        public int GroupId { get; set; }

        public virtual StudentInfo StudentInfo { get; set; }

        [BsonElement("StudentInfoId")]
        public int StudentInfoId { get; set; }
    }
}