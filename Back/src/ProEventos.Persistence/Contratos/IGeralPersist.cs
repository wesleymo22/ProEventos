
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IGeralPersist
    {
        //Geral
        void Add<t>(t entity) where t: class;
        void Update<t>(t entity) where t: class;
        void Delete<t>(t entity) where t: class;
        void DeleteRange<t>(t[] entity) where t: class;
        Task<bool> SaveChangesAsync();

    }
}