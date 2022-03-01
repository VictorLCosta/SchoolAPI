using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolApi.Data;
using SchoolApi.Data.Interfaces;
using SchoolApi.Data.Repositories;
using SchoolApi.Data.Transactions;

namespace SchoolApi.CrossCutting.DependencyInjection
{
    public static class ConfigureData
    {
        public static IServiceCollection AddDataDependecies(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(opt => {
                opt.UseSqlite(connectionString);
            });

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IUow, Uow>();

            return services;
        }
    }
}