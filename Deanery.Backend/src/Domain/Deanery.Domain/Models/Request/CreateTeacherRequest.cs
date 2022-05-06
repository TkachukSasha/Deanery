namespace Deanery.Domain.Models.Request
{
    public class CreateTeacherRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomyc { get; set; }
        public int CathedraId { get; set; }
        public int SubjectId { get; set; }
    }
}
