namespace Condominio.Adm.Dominio.Repositorios
{
    public interface IUpdateRepository<T> where T : class
    {
        void Update(T t);
        void Update(IEnumerable<T> t);
    }
}
