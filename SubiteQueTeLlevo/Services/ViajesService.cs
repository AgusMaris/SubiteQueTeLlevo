using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SubiteQueTeLlevo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SubiteQueTeLlevo.Services
{
    
    public class ViajesService:IViajesService
    {
        private readonly UserManager<Perfil> _userManager;
        public static PreferenciasModel preferencias;
        private readonly SQTLDbContext _repo;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ViajesService(SQTLDbContext repo, UserManager<Perfil> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _repo = repo;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            
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
            if (preferencias == null)
            {
                preferencias = new PreferenciasModel
                {
                    DisponibilidadEquipaje = true,
                    AntiguedadAuto = 3000,
                    CalificacionConductor = 0,
                    LugaresDisponibles = 0
                };
            }
            var viajes = _repo.Viajes.Where(v => v.Destino.Ciudad.Nombre.Contains(ciudadD))
                .Where(v => v.Origen.Ciudad.Nombre.Contains(ciudadO))
                .Where(v=> v.DisponibilidadEquipaje==preferencias.DisponibilidadEquipaje)
                .Where(v=> v.Auto.Dueño.ClasificacionPromedio>=preferencias.CalificacionConductor)
                .Where(v=> (DateTime.Now.Year - v.Auto.Modelo.Anio)<=preferencias.AntiguedadAuto)
                .Where(v => v.FyHSalida >= fecha)
                .Where(v=> (v.AsientosTotales-v.ViajePerfil.Count)>=preferencias.LugaresDisponibles)
                .Where(v=> v.EstadoViajeId==EstadoViajeId.Pendiente)
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

        public List<Perfil> TraerViajePerfilIdV(int idViaje)
        {
            var viaje = _repo.Viajes.Where(v => v.ViajeId == idViaje).Include(v=>v.ViajePerfil)
                .ThenInclude(vp => vp.Perfil).First();
            List<Perfil> acompañantes = new List<Perfil>();
            foreach (ViajePerfil vp in viaje.ViajePerfil)
            {
                acompañantes.Add(vp.Perfil);
            }
            return acompañantes;
        }

        [Authorize]
        public async Task UnirseViaje(int idViaje)
        {
            ViajePerfil vp = new ViajePerfil();
            var user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);
            vp.PerfilId = user.Id;
     
            vp.ViajeId = idViaje;
            vp.EstadoViajePerfilId = EstadoViajePerfilId.PendienteAceptacion;
            _repo.Add(vp);
            _repo.SaveChanges();
        }
        public void GuardarPreferencias(bool DispEquipaje, int LugaresDisponibles, int CalificacionConductor, int AntiguedadAuto)
        {
            preferencias = new PreferenciasModel();
            preferencias.AntiguedadAuto = AntiguedadAuto;
            preferencias.DisponibilidadEquipaje = DispEquipaje;
            preferencias.CalificacionConductor = CalificacionConductor;
            preferencias.LugaresDisponibles = LugaresDisponibles;
        }
    }
}
