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
        public Task<Viaje> TraerViajeId(int id);
        public Task<Viaje> TraerViajeIdCiudadOrigen(int id);
        public Task<Viaje> TraerViajeIdCiudadDestino(int id);
        public Task<bool> UnirseViaje(Viaje v);
        public Task<bool> ConfirmarPasajero(ViajePerfil vp);
        public Task<bool> CrearViajePerfil(ViajePerfil vp);
        public Task<bool> ModificarViajePerfil(ViajePerfil vp);
    }
}
