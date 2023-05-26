using BackEnd_Ecollama.DataBase;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Ecollama.Repositories
{
    public class ProductosRepository: IProducto
    {
        private readonly DBContextEcollama _dBContextEcollama;

        public ProductosRepository(DBContextEcollama dBContextEcollama)
        {
            _dBContextEcollama = dBContextEcollama;
        }
        public async Task<IEnumerable<Productos>> GetAll()
        {
            try
            {
                return await _dBContextEcollama.Productos.ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
    
}
