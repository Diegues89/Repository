using BackEnd_Ecollama.Models;

namespace BackEnd_Ecollama.Repositories.Interfaces
{
    public interface IVentasDetalleRepository
    {
        Task<IEnumerable<VentasDetalle>> GetAll();
    }
}
