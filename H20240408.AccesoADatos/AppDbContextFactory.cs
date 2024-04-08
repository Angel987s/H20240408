using H20240408.AccesoADatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace H20240408.AccesoADatos
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            const string conn = "Data Source=.;Initial Catalog=H20240408DB;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(conn);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}