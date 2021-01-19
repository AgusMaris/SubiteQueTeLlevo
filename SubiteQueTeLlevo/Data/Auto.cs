using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubiteQueTeLlevo.Data
{
    public class Auto
    {
        [Key]
        public int AutoId { get; set; }
        
        public string Patente { get; set; }
        [ForeignKey("Modelo")]
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        [ForeignKey("Dueño")]
        [MaxLength(450)]
        public string DueñoId { get; set; }
        public Perfil Dueño { get; set; }
    }
}