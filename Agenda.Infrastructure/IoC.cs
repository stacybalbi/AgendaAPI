using Agenda.Application.Interfaces;
using Agenda.Infrastructure.Context;
using Agenda.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAgendaContext, AgendaContext>();

            services.AddDbContext<AgendaContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConection")));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
