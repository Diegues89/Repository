using BackEnd_Ecollama.DataBase;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Ecollama.Repositories
{
    public class VentasDetalleRepository: IVentasDetalleRepository
    {
        private readonly DBContextEcollama _dBContextEcollama;

        public VentasDetalleRepository(DBContextEcollama dBContextEcollama)
        {
            _dBContextEcollama = dBContextEcollama;

        }

        public async Task<IEnumerable<VentasDetalle>> GetAll()
        {
            try
            {
                return await _dBContextEcollama.Set<VentasDetalle>().ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
            

        }
    }
}
