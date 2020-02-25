using Microsoft.EntityFrameworkCore;
using Orchidea.Data.Models;
using System;

namespace Orchidea.Data.Configuration
{
    public static class FlowerConfigurator
    {
        public static void Configurate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flower>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Flower>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Flower>()
                .HasData
                (
                new Flower
                {
                    Id = Guid.NewGuid(),
                    Name = "Orchidea"
                },
                new Flower
                {
                    Id = Guid.NewGuid(),
                    Name = "Rose"
                },
                new Flower
                {
                    Id = Guid.NewGuid(),
                    Name = "Snowdrop"
                },
                new Flower
                {
                    Id = Guid.NewGuid(),
                    Name = "Bluebell"
                },
                new Flower
                {
                    Id = Guid.NewGuid(),
                    Name = "Daffodil"
                }
                );

        }
    }
}
