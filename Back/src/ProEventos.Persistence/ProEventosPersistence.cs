
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence
    {
        private readonly ProEventosContext _context;

        public ProEventosPersistence(ProEventosContext context)
        {
            _context = context;
        }

        public void Add<t>(t entity) where t : class
        {
            _context.Add(entity);
        }

        public void Update<t>(t entity) where t : class
        {
            _context.Update(entity);
        }

        public void Delete<t>(t entity) where t : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<t>(t[] entity) where t : class
        {
            _context.RemoveRange(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {

            return (await _context.SaveChangesAsync()) > 0;
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(string Nome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos)
        {
            throw new NotImplementedException();
        }
    }
}