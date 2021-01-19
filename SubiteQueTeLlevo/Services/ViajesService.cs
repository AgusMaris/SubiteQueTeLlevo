using SubiteQueTeLlevo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubiteQueTeLlevo.Services
{
    public class ViajesService:IViajesService
    {
        SQTLDbContext _repo;
        public ViajesService(SQTLDbContext repo)
        {
            _repo = repo;
        }

        public Task<bool> ConfirmarPasajero(ViajePerfil vp)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CrearViajePerfil(ViajePerfil vp)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModificarViajePerfil(ViajePerfil vp)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Viaje>> TraerTodosViajes()
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeIdCiudadDestino(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeIdCiudadOrigen(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnirseViaje(Viaje v)
        {
            throw new NotImplementedException();
        }
    }
}
