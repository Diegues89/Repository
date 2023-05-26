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
    public class VentaController : ControllerBase
    {
        private readonly DBContextEcollama _dBContextEcollama;

        public VentaController(DBContextEcollama dBContextEcollama)
        {
            _dBContextEcollama = dBContextEcollama;
        }
        // GET: api/<VentaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VentaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VentaController>
        [HttpPost]
        public async Task<Venta> Post([FromBody] Venta venta)
        {
            _dBContextEcollama.Venta.Add(venta);
            await _dBContextEcollama.SaveChangesAsync();

            return venta;
        }

        // PUT api/<VentaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VentaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
