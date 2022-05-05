using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Deanery.Domain.Entities
{
    public class Cathedra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public virtual Faculty Faculty { get; set; }

        [BsonElement("FacultyId")]
        public int FacultyId { get; set; }

        public virtual BaseEntity BaseEntity { get; set; }

        [BsonElement("DataId")]
        public BaseEntity DataId { get; set; }

        [BsonElement("Specialties")]
        public IEnumerable<Specialty> Specialties { get; set; }
    }
}