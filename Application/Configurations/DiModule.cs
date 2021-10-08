using Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Presistence;
using Presistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configurations
{
    public class DiModule
    {
        public static IServiceCollection Register(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IIdeaService, IdeaService>();
            services.AddTransient<IIdeaRepository, IdeaRepository>();
            services.AddDbContext<IdeasDbContext>(x => x.UseSqlServer(connectionString));

            return services;
        }
    }
}
