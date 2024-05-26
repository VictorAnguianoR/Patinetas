using Patinetas.Modelos;

namespace Patinetas.Modelos
{
    public interface IRepositoriosVentas
    {
        Task<List<Venta>> GetAll();
        Task<Venta?> Get(int id);
        Task<Venta> Add(Venta venta);
        Task Update(int id, Venta venta);
        Task Delete(int id);
    }
}