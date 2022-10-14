using Agenda.Application.User.Handlers;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application
{
    public class IoC
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddTransient<IUserHandler, UserHandler>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
