using Kodlama.io.Devs.Application.Services;
using Kodlama.io.Devs.Persistance.Context;
using Kodlama.io.Devs.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                        IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("KodlamaIoDevsConnectionString")));
            services.AddScoped<IProgrammingLanguagesRepository, ProgrammingLanguagesRepository>();

            return services;
        }
    }
}
