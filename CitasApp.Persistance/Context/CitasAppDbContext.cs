

namespace CitasApp.Infraestructure.Context
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Reflection.Emit;

    public class CitasAppDbContext : DbContext
    {
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        public CitasAppDbContext(DbContextOptions<CitasAppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales del modelo
        }
    }

    public class Pago
    {
    }

    public class Servicio
    {
    }

    public class Usuario
    {
    }

    public class Cita
    {
    }
}

