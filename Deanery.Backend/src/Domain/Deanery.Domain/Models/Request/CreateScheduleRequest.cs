using System;

namespace Deanery.Domain.Models.Request
{
    public class CreateScheduleRequest
    {
        public DateTime StartOfLesson { get; set; }
        public int CathedraId { get; set; }
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
        public int GroupId { get; set; }
        public int TeacherId { get; set; }
        public int AudienceId { get; set; }
    }
}
