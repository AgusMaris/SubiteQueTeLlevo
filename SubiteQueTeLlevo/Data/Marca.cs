using System.ComponentModel.DataAnnotations;

namespace SubiteQueTeLlevo.Data
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
    }
}