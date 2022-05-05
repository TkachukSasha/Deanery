using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Deanery.Dal.Data
{
    public class DeaneryDbContext : IDeaneryDbContext
    {
        public DeaneryDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            University = database.GetCollection<University>("University");
            Faculty = database.GetCollection<Faculty>("Faculty");
            Cathedra = database.GetCollection<Cathedra>("Cathedra");
            Specialty = database.GetCollection<Specialty>("Specialty");
            Deanery = database.GetCollection<DeaneryOffice>("Deanery");
            Subject = database.GetCollection<Subject>("Subject");
            Teacher = database.GetCollection<Teacher>("Teacher");
            Schedule = database.GetCollection<Schedule>("Schedule");
            Group = database.GetCollection<Group>("Group");
            Audience = database.GetCollection<Audience>("Audience");
            Course = database.GetCollection<Course>("Course");
            Student = database.GetCollection<Student>("Student");
            StudentInfo = database.GetCollection<StudentInfo>("StudentInfo");
            RecordBook = database.GetCollection<RecordBook>("RecordBook");
        }

        public IMongoCollection<University> University { get; }
        public IMongoCollection<Faculty> Faculty { get; }
        public IMongoCollection<Cathedra> Cathedra { get; }
        public IMongoCollection<Specialty> Specialty { get; }
        public IMongoCollection<DeaneryOffice> Deanery { get; }
        public IMongoCollection<Subject> Subject { get; }
        public IMongoCollection<Teacher> Teacher { get; }
        public IMongoCollection<Schedule> Schedule { get; }
        public IMongoCollection<Group> Group { get; }
        public IMongoCollection<Audience> Audience { get; }
        public IMongoCollection<Course> Course { get; }
        public IMongoCollection<Student> Student { get; }
        public IMongoCollection<StudentInfo> StudentInfo { get; }
        public IMongoCollection<RecordBook> RecordBook { get; }
    }
}
