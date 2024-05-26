using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Patinetas.Modelos
{
    public class PatinetasDBContext : DbContext
    {
        public PatinetasDBContext(DbContextOptions<PatinetasDBContext> options) : base(options)
        {

        }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Venta> Ventas { get; set; }
    }
}