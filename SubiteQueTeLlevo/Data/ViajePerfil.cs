using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubiteQueTeLlevo.Data
{
    public class ViajePerfil
    {
        [Key]
        public int ViajePerfilId { get; set; }
        [ForeignKey("Viaje")]
        public int ViajeId { get; set; }
        
        public Viaje Viaje { get; set; }
        
        [MaxLength(450)]
        [ForeignKey("Perfil")]
        public string PerfilId { get; set; }
        
        public Perfil Perfil { get; set; }
        public int EstadoViajePerfilId { get; set; }
        public EstadoViajePerfil EstadoViajePerfil { get; set; }
    }
    public enum EstadoViajePerfil
    {
        Cancelado,
        Completado,
        PendienteAceptacion,
        Reservado
    }
}