using Microsoft.AspNetCore.Mvc;
using MontadoraCarroApi.data;
using MontadoraCarroApi.model;

namespace MontadoraCarroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MontadoraController : ControllerBase

    {
        private static List<Montadora> montadoras = new List<Montadora>();
        private Montadora montadora = new Montadora();
        private readonly DbApllication _contexto;

        public MontadoraController(DbApllication contexto)
        {
            _contexto = contexto;
        }

        [HttpPost]
        public void AddMontadora([FromBody] Montadora montadora)
        {
            _contexto.Montadora.Add(montadora);
            _contexto.SaveChanges();
        }

        [HttpGet]
        public List<Montadora> Get()
        {
            return _contexto.Montadora.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult GetMontadorPorId(int id)
        {
            montadora = _contexto.Montadora.FirstOrDefault(montadora => montadora.Id == id);
            if (montadora != null) {
                return Ok(montadora);
            }
            return NotFound();
            
        }

        [HttpDelete("{id}")]
        public void ExcluirPoiId(int id)
        {
            var montadoraExcluir = _contexto.Montadora.FirstOrDefault(montadora => montadora.Id == id);
            if (montadoraExcluir != null)
            {
                _contexto.Montadora.Remove(montadoraExcluir);
                _contexto.SaveChanges();
            }

        }

    }
}
