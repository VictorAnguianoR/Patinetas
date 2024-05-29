using Microsoft.EntityFrameworkCore;
using Patinetas.Modelos;

namespace Patinetas.Repositorio
{
    public class RepositorioProveedor : IRepositorioProveedores
    {
        private readonly PatinetasDBContext _context;

        public RepositorioProveedor(PatinetasDBContext context)
        {
            _context = context;
        }
        public async Task<Proveedor> Add(Proveedor proveedor)
        {
            await _context.Proveedores.AddAsync(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task Delete(int Id)
        {
            var proveedor = await _context.Proveedores.FindAsync(Id);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor?> Get(int Id)
        {
            return await _context.Proveedores.FindAsync(Id);
        }

        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task Update(int Id, Proveedor proveedor)
        {
            var proveedorActual = await _context.Proveedores.FindAsync(Id);
            if (proveedorActual != null)
            {
                proveedorActual.Nombre = proveedor.Nombre;
                proveedorActual.Correo = proveedor.Correo;
                proveedorActual.ClaveProducto = proveedor.ClaveProducto;
                await _context.SaveChangesAsync();
            }
        }
    }
}