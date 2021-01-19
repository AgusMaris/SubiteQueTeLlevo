using System.ComponentModel.DataAnnotations;

namespace SubiteQueTeLlevo.Data
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }
    }
}