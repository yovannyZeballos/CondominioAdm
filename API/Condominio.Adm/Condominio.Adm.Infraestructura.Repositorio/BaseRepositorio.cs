using Condominio.Adm.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Adm.Infraestructura.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected readonly DbContext _contexto;
        protected readonly DbSet<T> _tabla;
        public BaseRepositorio(DbContext contexto)
        {
            _contexto = contexto;
            _tabla = contexto.Set<T>();
        }
        public async Task<bool> Add(T Entidad)
        {
            var d = await _tabla.AddAsync(Entidad);
            return true;
        }
        public IEnumerable<T> Lista()
        {
            return _tabla.ToList();
        }
        public bool Update(T Entidad)
        {
            _tabla.Attach(Entidad);
            _contexto.Entry(Entidad).State = EntityState.Modified;
            return true;
        }
    }
}
