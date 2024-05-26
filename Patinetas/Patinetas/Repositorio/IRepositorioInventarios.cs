using Patinetas.Modelos;

namespace Patinetas.Modelos
{
    public interface IRepositorioInventarios
    {
        Task<List<Inventario>> GetAll();
        Task<Inventario?> Get(int id);
        Task<Inventario> Add(Inventario inventario);
        Task Update(int id, Inventario inventario);
        Task Delete(int id);
    }
}