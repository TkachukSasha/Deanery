using Deanery.Api.Helpers.DI.Contracts;
using Deanery.Extensions.Common.Mapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Deanery.Api.Helpers.DI.Services
{
    public class DefaultServices : IConfigureServices
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(DeaneryProfile));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Deanery.Api", Version = "v1" });
            });
        }
    }
}
