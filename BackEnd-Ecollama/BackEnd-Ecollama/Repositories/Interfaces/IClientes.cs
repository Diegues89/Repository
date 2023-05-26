using BackEnd_Ecollama.Models;

namespace BackEnd_Ecollama.Repositories.Interfaces
{
    public interface IClientes
    {
        Task<IEnumerable<Clientes>> GetAll();
    }
}
