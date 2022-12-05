using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 6",
                Local = "Sao Paulo",
                Lote = "1 Lote",
                QtdPessoas =  250,
                DataEvento = DateTime.Now.AddDays(7),
                ImgURL = "Foto.png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angular 12 e .NET 6",
                Local = "Sao Paulo",
                Lote = "2 Lote",
                QtdPessoas =  500,
                DataEvento = DateTime.Now.AddDays(7),
                ImgURL = "Foto2.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
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