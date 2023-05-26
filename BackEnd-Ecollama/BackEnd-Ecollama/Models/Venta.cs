using System.ComponentModel.DataAnnotations;

namespace BackEnd_Ecollama.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdCliente { get; set; }
        public int Pallets { get; set; }
        public int Bolsas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string FormaPago { get; set; }
        public string Transporte { get; set; }
        public Boolean Despachado { get; set; }
        public Boolean Abonado { get; set; }

    }
}
