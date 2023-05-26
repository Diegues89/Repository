using AutoMapper;
using BackEnd_Ecollama.DataBase;
using BackEnd_Ecollama.Models;
using BackEnd_Ecollama.Models.DTOs;
using BackEnd_Ecollama.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd_Ecollama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly DBContextEcollama _dBContextEcollama;
        private readonly IMapper _mapper;

        public VentasController(DBContextEcollama dBContextEcollama, IMapper mapper)
        {
            _dBContextEcollama = dBContextEcollama;
            _mapper = mapper;
        }
        // GET: api/<VentasController>
        [HttpGet]
        public async Task<IEnumerable<VentasDetalleDTO>> Get()
        {
            var repository = new VentasDetalleRepository(_dBContextEcollama);
            var data = await repository.GetAll();

            return _mapper.Map<List<VentasDetalleDTO>>(data);//Aquí se hace el mapeo
            //return data.ToList();
        }

        // GET api/<VentasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VentasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VentasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VentasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
