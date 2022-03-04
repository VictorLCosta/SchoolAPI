using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolApi.CrossCutting.DependencyInjection
{
    public static class ConfigureWeb
    {
        public static IServiceCollection AddWebDependecies(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddApiVersioning(opt => {
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = ApiVersion.Default;
                opt.ApiVersionReader = new HeaderApiVersionReader("X-Version");

                opt.ReportApiVersions = true;
            });

            return services;
        }
    }
}