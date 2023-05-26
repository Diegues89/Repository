using System.ComponentModel.DataAnnotations;

namespace BackEnd_Ecollama.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
    }
}
