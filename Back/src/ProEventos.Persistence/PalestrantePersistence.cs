
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {
        private readonly ProEventosContext _context;

        public PalestrantePersist(ProEventosContext context)
        {
            _context = context;
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);

            if(includeEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                    .ThenInclude(e => e.Evento);
            }

            query = query.OrderBy(p => p.Id)
                .Where(p => p.Nome.ToLower().Contains(Nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);

            if(includeEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                    .ThenInclude(e => e.Evento);
            }

            query = query.OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p => p.RedesSociais);

            if(includeEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                    .ThenInclude(e => e.Evento);
            }

            query = query.OrderBy(p => p.Id == PalestranteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}