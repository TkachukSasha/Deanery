using Deanery.Domain.Entities;
using System.Collections.Generic;

namespace Deanery.Domain.Models.Request
{
    public class CreateGroupRequest
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
