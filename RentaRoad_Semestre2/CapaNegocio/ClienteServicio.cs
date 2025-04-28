using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class ClienteServicio
    {
        private readonly ClienteRepositorio _repo;

        public ClienteServicio(ClienteRepositorio repo)
        {
            _repo = repo;
        }

        public List<Cliente> ObtenerTodos()
        {
            return _repo.GetAllClientes();
        }

        public void CrearCliente(Cliente clien)
        {
            // Validaciones
            if (string.IsNullOrEmpty(clien.NombreCliente))
                throw new Exception("El nombre es obligatorio");

            _repo.Add(clien);
        }

        public void ActualizarCliente(Cliente clien)
        {
            // Validaciones extra
            _repo.Update(clien);
        }

        public void EliminarCliente(string cedula)
        {
            _repo.Delete(cedula);
        }
    }
}
