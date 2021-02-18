using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubiteQueTeLlevo.Data
{
    public class Viaje
    {
        [Key]
        public int ViajeId { get; set; }
        public int AsientosTotales { get; set; }
        public float Precio { get; set; }
        public bool DisponibilidadEquipaje { get; set; }
        public DateTime FyHSalida { get; set; }
        public int TiempoEstimado { get; set; }
        [ForeignKey("EstadoViaje")]
        public EstadoViajeId EstadoViajeId { get; set; }
        public EstadoViaje EstadoViaje { get; set; }
        [ForeignKey("Auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }

        [ForeignKey("Origen")]
        public int? OrigenId { get; set; }
        
        public Direccion Origen { get; set; }

        [ForeignKey("Destino")]
        public int? DestinoId { get; set; }
        
        public Direccion Destino { get; set; }
        public List<ViajePerfil> ViajePerfil { get; set; }

    }

    public class EstadoViaje
    {
        public EstadoViajeId EstadoViajeId { get; set; }
        public string Nombre { get; set; }
        public List<Viaje> Viajes { get; set; }
    }

    public enum EstadoViajeId:int
    {
        Pendiente = 0,
        Cancelado = 1 ,
        Completado = 2
    }
}
