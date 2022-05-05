using Deanery.Domain.Entities;
using MongoDB.Driver;

namespace Deanery.Application.Common.Contracts
{
    public interface IDeaneryDbContext
    {
        IMongoCollection<University> University { get; }
        IMongoCollection<Faculty> Faculty { get; }
        IMongoCollection<Cathedra> Cathedra { get; }
        IMongoCollection<Specialty> Specialty { get; }
        IMongoCollection<DeaneryOffice> Deanery { get; }
        IMongoCollection<Subject> Subject { get; }
        IMongoCollection<Teacher> Teacher { get; }
        IMongoCollection<Schedule> Schedule { get; }
        IMongoCollection<Group> Group { get; }
        IMongoCollection<Audience> Audience { get; }
        IMongoCollection<Course> Course { get; }
        IMongoCollection<Student> Student { get; }
        IMongoCollection<StudentInfo> StudentInfo { get; }
        IMongoCollection<RecordBook> RecordBook { get; }
    }
}
