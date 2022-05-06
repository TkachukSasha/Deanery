using Deanery.Domain.Entities;
using System;

namespace Deanery.Domain.Models.Request
{
    public class CreateStudentRequest
    {
        public EducationForm EducationForm { get; set; }
        public StatusOfEducation StatusOfEducation { get; set; }
        public DateTime StartOfEducation { get; set; }
        public DateTime EndOfEducation { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronomyc { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
