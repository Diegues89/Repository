using AutoMapper;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Models.DTOs;

namespace BackEnd_Ecollama.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<VentasDetalle, VentasDetalleDTO>().ReverseMap();
            CreateMap<Productos, ProductosDTO>().ReverseMap();
            CreateMap<Clientes, ClientesDTO>().ReverseMap();
        }
    }
}
