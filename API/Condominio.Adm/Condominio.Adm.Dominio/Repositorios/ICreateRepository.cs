namespace Condominio.Adm.Dominio.Repositorios
{
    public interface ICreateRepository<T> where T : class
    {
        void Add(T t);
        void Add(IEnumerable<T> t);
        Task<T> AddAsync(T t);
        Task AddAsync(IEnumerable<T> t);
    }
}
