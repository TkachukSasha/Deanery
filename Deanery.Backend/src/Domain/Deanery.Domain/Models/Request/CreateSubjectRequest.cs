using Deanery.Domain.Entities;
using System.Collections.Generic;

namespace Deanery.Domain.Models.Request
{
    public class CreateSubjectRequest
    {
        public string Name { get; set; }

        public LessonType LessonType { get; set; }

        public int TeacherId { get; set; }

        public int CathedraId { get; set; }

        public IEnumerable<Group> Groups { get; set; }
    }
}
