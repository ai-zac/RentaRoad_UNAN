// CapaDatos/Repositorios/UsuarioRepository.cs

using Microsoft.EntityFrameworkCore;
using RentaRoad_Semestre3.CapaPresentacion.Modelos; // Ajustar namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    public class UsuarioRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public UsuarioRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<TipoUsuario> GetAllTipoUsuario()
        {
            return _context.TipoUsuarios.ToList();
        }

        public List<CargoEmpleado> GetAllCargoEmpleado()
        {
            return _context.CargoEmpleados.ToList();
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? GetById(int FkIdTipoUsuario, int Id, int FkIdCargoEmpleado)
        {
            return _context.Usuarios.Find(FkIdTipoUsuario, Id, FkIdCargoEmpleado);
        }

        public void Add(Usuario usua)
        {
            _context.Usuarios.Add(usua);
            _context.SaveChanges();
        }

        public void Update(Usuario usua)
        {
            _context.Usuarios.Update(usua);
            _context.SaveChanges();
        }

        public void ChangeCargoEmpleado(Usuario usua,CargoEmpleado oldCargo, CargoEmpleado newCargo)
        {
            _context.Database.ExecuteSql($"UPDATE [Usuario] SET [Fk_Cargo_empleado] = {newCargo.IdCargoEmpleado} WHERE [Id_Usuario] = {usua.IdUsuario}");
            _context.SaveChanges();
        }

        public void ChangeTipoUsuarios(Usuario usua, TipoUsuario oldTipo, TipoUsuario newTipo)
        {
            _context.Database.ExecuteSql($"UPDATE [Usuario] SET [Fk_Tipo_Usuario] = {newTipo.IdTipoUsuario} WHERE [Id_Usuario] = {usua.IdUsuario}");
            _context.SaveChanges();
        }

        public void Delete(int FkIdTipoUsuario, int Id, int FkIdCargoEmpleado)
        {
            var u = GetById(FkIdTipoUsuario, Id, FkIdCargoEmpleado);
            if (u != null)
            {
                _context.Usuarios.Remove(u);
                _context.SaveChanges();
            }
        }
    }
}
