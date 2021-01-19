using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubiteQueTeLlevo.Data
{
    public class Ciudad
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("Provincia")]
        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }
    }
}