using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Deanery.Domain.Entities
{
    public class Faculty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public virtual University University { get; set; }

        [BsonElement("UniversityId")]
        public int UniversityId { get; set; }

        public virtual BaseEntity BaseEntity { get; set; }

        [BsonElement("DataId")]
        public int DataId  { get; set; }

        [BsonElement("Cathedrals")]
        public IEnumerable<Cathedra> Cathedrals { get; set; }
    }
}