using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Model;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete id = {id}";
        }
    }
}