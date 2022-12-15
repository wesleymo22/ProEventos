
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contexto;
using ProEventos.Persistence.Contratos;


namespace ProEventos.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProEventosContext _context;

        public GeralPersist(ProEventosContext context)
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

    }
}