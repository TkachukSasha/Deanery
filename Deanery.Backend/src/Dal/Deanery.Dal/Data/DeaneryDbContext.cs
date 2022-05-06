using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Deanery.Dal.Data
{
    public class DeaneryDbContext : IDeaneryDbContext
    {
        private IMongoDatabase Database { get; set; }
        private MongoClient Client { get; set; }

        public DeaneryDbContext(IConfiguration configuration)
        {
            Client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            Database = Client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            University = Database.GetCollection<University>("University");
            Faculty = Database.GetCollection<Faculty>("Faculty");
            Cathedra = Database.GetCollection<Cathedra>("Cathedra");
            Specialty = Database.GetCollection<Specialty>("Specialty");
            Deanery = Database.GetCollection<DeaneryOffice>("Deanery");
            Subject = Database.GetCollection<Subject>("Subject");
            Teacher = Database.GetCollection<Teacher>("Teacher");
            Schedule = Database.GetCollection<Schedule>("Schedule");
            Group = Database.GetCollection<Group>("Group");
            Audience = Database.GetCollection<Audience>("Audience");
            Course = Database.GetCollection<Course>("Course");
            Student = Database.GetCollection<Student>("Student");
            StudentInfo = Database.GetCollection<StudentInfo>("StudentInfo");
            RecordBook = Database.GetCollection<RecordBook>("RecordBook");
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

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return Database.GetCollection<T>(name);
        }
    }
}
