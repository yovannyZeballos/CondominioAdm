namespace Condominio.Adm.Dominio.Repositorios
{
    public interface IRemoveRepository<T> where T : class
    {
        void Remove(T t);
        void Remove(IEnumerable<T> t);
    }
}
