using Condominio.Adm.Dominio.Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Adm.Infraestructura.Contexto
{
    public class CondominioContexto : DbContext
    {
        public CondominioContexto(DbContextOptions<CondominioContexto> option) : base(option)
        {

        }

        public DbSet<Torre> Torres { get; set; }
    }
}
