using Deanery.Api.Helpers.DI.Contracts;
using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Deanery.Api.Helpers.DI.Services
{
    public class DatabaseServices : IConfigureServices
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var connetionString = configuration["DatabaseSettings:ConnectionString"];
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseService<>));
            services.AddHealthChecks().AddMongoDb(connetionString, "MongoDb Health", HealthStatus.Degraded);
        }
    }
}
