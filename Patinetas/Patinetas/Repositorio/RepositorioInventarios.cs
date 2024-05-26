using Microsoft.EntityFrameworkCore;
using Patinetas.Modelos;


namespace Patinetas.Repositorio
{
    public class RepositorioInventario : IRepositorioInventarios
    {
        private readonly PatinetasDBContext _context;

        public RepositorioInventario(PatinetasDBContext context)
        {
            _context = context;
        }
        public async Task<Inventario> Add(Inventario inventario)
        {
            await _context.Inventarios.AddAsync(inventario);
            await _context.SaveChangesAsync();
            return inventario;
        }

       
        public async Task Delete(int Id)
        {
            var inventario = await _context.Inventarios.FindAsync(Id);
            if (inventario != null)
            {
                _context.Inventarios.Remove(inventario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Inventario?> Get(int Id)
        {
            return await _context.Inventarios.FindAsync(Id);
        }

        public async Task<List<Inventario>> GetAll()
        {
            return await _context.Inventarios.ToListAsync();
        }

        public async Task Update(int Id, Inventario inventario)
        {
            var inventarioActual = await _context.Inventarios.FindAsync(Id);
            if (inventarioActual != null)
            {
                inventarioActual.NombreProducto = inventario.NombreProducto;
                inventarioActual.CantidadDisponible = inventario.CantidadDisponible;
                inventarioActual.Precio = inventario.Precio;
                inventarioActual.ProveedorId = inventario.ProveedorId;
                await _context.SaveChangesAsync();
            }
        }
    }
}