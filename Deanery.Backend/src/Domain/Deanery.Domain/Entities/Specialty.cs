using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Deanery.Domain.Entities
{
    public class Specialty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        public virtual Cathedra Cathedra { get; set; }

        [BsonElement("CathedraId")]
        public int CathedraId { get; set; }

        public virtual Deanery Deanery { get; set; }

        [BsonElement("DeaneryId")]
        public int DeaneryId { get; set; }

        [BsonElement("Subjects")]
        public IEnumerable<Subject> Subjects { get; set; }

        [BsonElement("Teachers")]
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}