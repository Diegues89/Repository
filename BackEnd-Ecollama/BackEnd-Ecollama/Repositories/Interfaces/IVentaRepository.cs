using BackEnd_Ecollama.Models;

namespace BackEnd_Ecollama.Repositories.Interfaces
{
    public interface IVentaRepository
    {
        Task<Venta> Create(Venta venta);
    }
}
