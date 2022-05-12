using Deanery.Api.Helpers.DI.Contracts;
using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Services;
using Deanery.Dal.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Deanery.Api.Helpers.DI.Services
{
    public class DatabaseServices : IConfigureServices
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDeaneryDbContext, DeaneryDbContext>();
            services.AddScoped<IGroupRepository, GroupService>();
            services.AddScoped<IStudentRepository, StudentService>();
            services.AddScoped<IScheduleRepository, ScheduleService>();
            services.AddScoped<ISubjectRepository, SubjectService>();
            services.AddScoped<ITeacherRepository, TeacherService>();
            services.AddHealthChecks().AddMongoDb(configuration["DatabaseSettings:ConnectionString"], "MongoDb Health", HealthStatus.Degraded);
        }
    }
}
