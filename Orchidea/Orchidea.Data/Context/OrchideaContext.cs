using Microsoft.EntityFrameworkCore;
using Orchidea.Data.Configuration;
using Orchidea.Data.Models;

namespace Orchidea.Data.Context
{
    public class OrchideaContext : DbContext
    {
        public OrchideaContext(DbContextOptions<OrchideaContext> options) : base(options) { }

        public DbSet<Flower> Flowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FlowerConfigurator.Configurate(modelBuilder);
        }
    }
}
