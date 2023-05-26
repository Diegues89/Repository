using System.ComponentModel.DataAnnotations;

namespace BackEnd_Ecollama.Models
{
    public class Productos
    {
        [Key]
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioDistribuidor { get; set; }
        public decimal PrecioMayorista { get; set; }
        public decimal PrecioConsumidorFinal { get; set; }
    }
}
