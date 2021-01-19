using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubiteQueTeLlevo.Data
{
    public class ApplicationDbContext : IdentityDbContext<Perfil>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Viaje>()
                .Property(e => e.EstadoViajeId)
                .HasConversion<int>();

            modelBuilder
                .Entity<EstadoViaje>()
                .Property(e => e.EstadoViajeId)
                .HasConversion<int>();

            modelBuilder
                .Entity<EstadoViaje>().HasData(
                    Enum.GetValues(typeof(EstadoViajeId))
                        .Cast<EstadoViajeId>()
                        .Select(e => new EstadoViaje()
                        {
                            EstadoViajeId = e,
                            Nombre = e.ToString()
                        })
                );
            modelBuilder
                .Entity<ViajePerfil>()
                .Property(e => e.EstadoViajePerfilId)
                .HasConversion<int>();

            modelBuilder
                .Entity<EstadoViajePerfil>()
                .Property(e => e.EstadoViajePerfilId)
                .HasConversion<int>();

            modelBuilder
                .Entity<EstadoViajePerfil>().HasData(
                    Enum.GetValues(typeof(EstadoViajePerfilId))
                        .Cast<EstadoViajePerfilId>()
                        .Select(e => new EstadoViajePerfil()
                        {
                            EstadoViajePerfilId = e,
                            Nombre = e.ToString()
                        })
                );

        }

        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        
    }
}
