using API.Domain;
using API.Interface;
using API.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class DependecyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias (this IServiceCollection services)
        {
            services.AddSingleton<IAluno_Repository, AlunoRepository>();
            services.AddSingleton<IAlunoService, AlunoService>();
            return services;
        
        }

    }
}
