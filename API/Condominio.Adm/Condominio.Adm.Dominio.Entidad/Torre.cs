using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Condominio.Adm.Dominio.Entidad
{
    public class Torre : DatosAuditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTorre { get; set; }
        public string Descripcion { get; set; }
        public int Numero { get; set; }
        public short Estado { get; set; }
    }
}
