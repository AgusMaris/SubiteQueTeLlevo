using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubiteQueTeLlevo.Data
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        [ForeignKey("Ciudad")]
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}