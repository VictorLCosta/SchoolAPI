using Microsoft.AspNetCore.Mvc;
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

            return services;
        }
    }
}