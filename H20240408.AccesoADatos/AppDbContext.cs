using Microsoft.EntityFrameworkCore;
using H20240408.AccesoADatos;

namespace H20240408.AccesoADatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PersonaH> PersonasH { get; set; }
    }
}