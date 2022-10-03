using System.ComponentModel.DataAnnotations.Schema;

namespace Condominio.Adm.Dominio.Entidad
{
    public class DatosAuditoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

    }
}
