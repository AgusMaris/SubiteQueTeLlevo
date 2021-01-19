using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SubiteQueTeLlevo.Data
{
    public class Perfil:IdentityUser
    {
        public string Foto { get; set; }
        [Range(0,5)]
        public float ClasificacionPromedio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public bool EsPasajero { get; set; }
        public bool EsConductor { get; set; }
        public List<ViajePerfil> ViajePerfil { get; set; }

    }
}