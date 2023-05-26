using BackEnd_Ecollama.DataBase;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Ecollama.Repositories
{
    public class ClientesRepository: IClientes
    {
        private readonly DBContextEcollama _dBContextEcollama;

        public ClientesRepository(DBContextEcollama dBContextEcollama)
        {
            _dBContextEcollama = dBContextEcollama;
        }
        public async Task<IEnumerable<Clientes>> GetAll()
        {
            try
            {
                return await _dBContextEcollama.Clientes.ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
