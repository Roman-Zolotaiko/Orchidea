using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orchidea.Data.Context;

namespace Orchidea.Installers
{
    public static class DbInstaller
    {
        public static void Install(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<OrchideaContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
