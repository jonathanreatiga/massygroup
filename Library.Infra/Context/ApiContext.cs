using Library.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Library.Infra.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }

        public ApiContext()
        {

        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoNovedad> TipoNovedad { get; set; }
        public DbSet<NovedadesNomina> NovedadesNomina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("IdPersona");
            });

            modelBuilder.Entity<TipoNovedad>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("IdTipoNovedad");
            });

            modelBuilder.Entity<NovedadesNomina>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("IdNovedad");
            });
        }

    }
}
