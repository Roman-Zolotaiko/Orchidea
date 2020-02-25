using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Orchidea.Commands.Validators.Flower;
using System;
using System.Reflection;

namespace Orchidea.Installers
{
    public static class MVCInstaller
    {
        public static void Install(IServiceCollection services)
        {
            var queries = AppDomain.CurrentDomain.Load("Orchidea.Queries");
            var queryHandlers = AppDomain.CurrentDomain.Load("Orchidea.QueryHandlers");
            var commands = AppDomain.CurrentDomain.Load("Orchidea.Commands");
            var commandHandlers = AppDomain.CurrentDomain.Load("Orchidea.CommandHandlers");

            services.AddMediatR(Assembly.GetExecutingAssembly(), queries, queryHandlers, commands, commandHandlers);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Orchidea API", Version = "v1" });
            });

            services.addValidatedHandler
        }
    }
}
