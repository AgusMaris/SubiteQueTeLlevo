using System.Collections.Generic;
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
        public EstadoViajePerfilId EstadoViajePerfilId { get; set; }
        public EstadoViajePerfil EstadoViajePerfil { get; set; }
    }

    public class EstadoViajePerfil
    {
        public EstadoViajePerfilId EstadoViajePerfilId { get; set; }
        public string Nombre { get; set; }
        public List<ViajePerfil> ViajePerfil { get; set; }
    }

    public enum EstadoViajePerfilId:int
    {
        Cancelado=0,
        Completado=1,
        PendienteAceptacion=2,
        Reservado=3
    }
}