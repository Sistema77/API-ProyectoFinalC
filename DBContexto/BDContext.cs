using API_ProyectoFinal_C.Modelo;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {

        }

        public DbSet<UsuarioDAO>? usuarios { get; set; }
        public DbSet<CreditoDAO>? credito { get; set; }
        public DbSet<TransacionDAO>? transaciones { get; set; }
        public DbSet<CuentaDAO>? cuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDAO>().ToTable("Usuario", schema: "schemausuario");
            modelBuilder.Entity<TransacionDAO>().ToTable("Transacion", schema: "schemabody");
            modelBuilder.Entity<CuentaDAO>().ToTable("Cuenta", schema: "schemabody");
            modelBuilder.Entity<CreditoDAO>().ToTable("Credito", schema: "schemabody");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("tu_cadena_de_conexión_aquí",
                    b => b.MigrationsAssembly("NombreDeTuAsambleaDeMigraciones"));
            }
        }
    }
}
