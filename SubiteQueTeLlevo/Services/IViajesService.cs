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
        public Task<Viaje> TraerViajeId();
        public Task<Viaje> TraerViajeIdCiudadOrigen();
        public Task<Viaje> TraerViajeIdCiudadDestino();
        public Task<bool> UnirseViaje();
        public Task<bool> ConfirmarPasajero();
        public Task<bool> CrearViajePerfil();
        public Task<bool> ModificarViajePerfil();
    }
}
