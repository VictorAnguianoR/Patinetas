using Microsoft.EntityFrameworkCore;
using Patinetas.Modelos;

namespace Patinetas.Repositorio
{
    public class RepositorioVentas : IRepositoriosVentas
    {
        private readonly PatinetasDBContext _context;

        public RepositorioVentas(PatinetasDBContext context)
        {
            _context = context;
        }

        public async Task<Venta> Add(Venta venta)
        {
            await _context.Ventas.AddAsync(venta);
            await _context.SaveChangesAsync();
            return venta;
        }

        public async Task Delete(int Id)
        {
            var venta = await _context.Ventas.FindAsync(Id);
            if (venta != null)
            {
                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Venta?> Get(int Id)
        {
            return await _context.Ventas.FindAsync(Id);
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task Update(int Id, Venta venta)
        {
            var ventaActual = await _context.Ventas.FindAsync(Id);
            if (ventaActual != null)
            {
                ventaActual.FechaHora = venta.FechaHora;
                ventaActual.CantidadVendida = venta.CantidadVendida;
                ventaActual.PrecioTotal = venta.PrecioTotal;
                ventaActual.IdProducto = venta.IdProducto;
                await _context.SaveChangesAsync();
            }
        }
    }
}
