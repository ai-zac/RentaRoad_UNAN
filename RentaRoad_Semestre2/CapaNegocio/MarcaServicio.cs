using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class MarcaServicio
    {
        private readonly MarcaRepositorio _repo;

        public MarcaServicio(MarcaRepositorio repo)
        {
            _repo = repo;
        }

        public List<Marca> ObtenerTodos()
        {
            return _repo.GetAllMarcas();
        }
        public Marca? ObtenerPorID(int? id)
        {
            return ObtenerTodos().FirstOrDefault(c => c.IdMarca == id);
        }

        public void CrearMarca(Marca marca)
        {
            // Validaciones
            if (string.IsNullOrEmpty(marca.NombreMarca))
                throw new Exception("El nombre es obligatorio");

            _repo.Add(marca);
        }

        public void ActualizarMarca(Marca marca)
        {
            // Validaciones extra
            _repo.Update(marca);
        }

        public void EliminarMarca(int? id)
        {
            _repo.Delete(id);
        }

    }
}
