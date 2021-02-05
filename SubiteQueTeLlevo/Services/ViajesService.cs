using Microsoft.EntityFrameworkCore;
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

        public List<Viaje> TraerViajeBusqueda(string ciudadO, string ciudadD, DateTime fecha)
        {
            var viajes = _repo.Viajes.Where(v => v.Destino.Ciudad.Nombre.Contains(ciudadD))
                .Where(v => v.Origen.Ciudad.Nombre.Contains(ciudadO))
                .Where(v => v.FyHSalida >= fecha)
                .Include(v => v.Destino.Ciudad)
                .Include(v => v.Origen.Ciudad)
                .Include(v => v.ViajePerfil)
                .ToList();
            return viajes;
        }

        public Viaje TraerViajeId(int id)
        {
            var viaje = _repo.Viajes.Where(v => v.ViajeId == id)
                .Include(v=>v.Origen.Ciudad)
                .Include(v=>v.Destino.Ciudad)
                .Include(v=>v.ViajePerfil)
                .Include(v => v.Auto.Modelo.Marca)
                    .Include(v => v.Auto.Dueño)
                .First();
            return viaje;

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
