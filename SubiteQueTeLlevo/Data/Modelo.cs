using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubiteQueTeLlevo.Data
{
    public class Modelo
    {
        [Key]
        public int ModeloId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        [ForeignKey("Marca")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}