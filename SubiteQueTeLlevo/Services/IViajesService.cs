using SubiteQueTeLlevo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubiteQueTeLlevo.Services
{
    public interface IViajesService
    {
        //Viajes
        public Task<IEnumerable<Viaje>> TraerTodosViajes();
        public Viaje TraerViajeId(int id);
        public List<Viaje> TraerViajeBusqueda(string ciudadO, string ciudadD, DateTime fecha);
        public Task<bool> UnirseViaje(Viaje v);
        public Task<bool> ConfirmarPasajero(ViajePerfil vp);
        public Task<bool> CrearViajePerfil(ViajePerfil vp);
        public Task<bool> ModificarViajePerfil(ViajePerfil vp);
    }
}
