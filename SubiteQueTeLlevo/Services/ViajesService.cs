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

        public Task<bool> ConfirmarPasajero()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CrearViajePerfil()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModificarViajePerfil()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Viaje>> TraerTodosViajes()
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeId()
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeIdCiudadDestino()
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> TraerViajeIdCiudadOrigen()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnirseViaje()
        {
            throw new NotImplementedException();
        }
    }
}
