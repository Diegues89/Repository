using System.ComponentModel.DataAnnotations;

namespace BackEnd_Ecollama.Models
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Pallets { get; set; }
        public int Bolsas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string FormaPago { get; set; }
        public string Transporte { get; set; }
        public string Despachado { get; set; }
        public string Abonado { get; set; }
    }
}
