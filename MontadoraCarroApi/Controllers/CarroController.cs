using Microsoft.AspNetCore.Mvc;
using MontadoraCarroApi.data;
using MontadoraCarroApi.model;

namespace MontadoraCarroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private static List<Carro> carros = new List<Carro>();
        private readonly DbApllication _contexto;
        public CarroController(DbApllication contexto)
        {
            _contexto = contexto;
        }

        [HttpPost]
        public void AddCarro([FromBody] Carro carro)
        {
            _contexto.Carro.Add(carro);
            _contexto.SaveChanges();
        }

        [HttpGet]
        public List<Carro> Get()
        {
            return _contexto.Carro.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Carro> GetPorId(int id)
        {
          Carro carro = _contexto.Carro.FirstOrDefault(carro => carro.Id == id);

            if(carro != null)
            {
                return Ok(carro);
            }
            return NotFound();

        }
        [HttpDelete("{id}")]
        public void ExcluirPoiId(int id)
        {
            var carroExcluir = _contexto.Carro.FirstOrDefault(carro => carro.Id == id);
            if (carroExcluir != null)
            {
                _contexto.Carro.Remove(carroExcluir);
                _contexto.SaveChanges();
            }
           

        }
    }
}
