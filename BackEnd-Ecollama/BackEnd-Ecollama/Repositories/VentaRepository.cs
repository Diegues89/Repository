using BackEnd_Ecollama.DataBase;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Repositories.Interfaces;

namespace BackEnd_Ecollama.Repositories
{
    public class VentaRepository: IVentaRepository
    {
        private readonly DBContextEcollama _dBContextEcollama;

        public VentaRepository(DBContextEcollama dBContextEcollama)
        {
            _dBContextEcollama = dBContextEcollama;
        }

        public async Task<Venta> Create(Venta venta)
        {
            _dBContextEcollama.Venta.Add(venta);
            await _dBContextEcollama.SaveChangesAsync();

            return venta;
        }
    }
    
}
