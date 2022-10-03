using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Adm.Dominio.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        Task<bool> Agregar(T Entidad);
        Task<bool> Actualizar(T Entidad);
        Task<IEnumerable<T>> Listar();
        Task<T> Obtener(int id);
        Task Eliminar(int id);
    }
}
