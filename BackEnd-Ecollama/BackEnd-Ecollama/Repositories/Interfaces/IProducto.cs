using BackEnd_Ecollama.Models;

namespace BackEnd_Ecollama.Repositories.Interfaces
{
    public interface IProducto
    {
        Task<IEnumerable<Productos>> GetAll();
    }
}
