using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolApi.CrossCutting.AutoMapper;
using SchoolApi.Services.Interfaces;
using SchoolApi.Services.Services;

namespace SchoolApi.CrossCutting.DependencyInjection
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServicesDependecies(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddTransient<IStudentService, StudentService>();

            return services;
        }
    }
}