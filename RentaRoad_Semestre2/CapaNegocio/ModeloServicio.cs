using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class ModeloServicio
    {
        private readonly ModeloRepositorio _repo;

        public ModeloServicio(ModeloRepositorio repo)
        {
            _repo = repo;
        }

        public List<Modelo> ObtenerTodos()
        {
            return _repo.GetAllModelos();
        }
        public Modelo? ObtenerPorID(int? id)
        {
            return ObtenerTodos().FirstOrDefault(c => c.IdModelo == id);
        }

        public void CrearModelo(Modelo modelo)
        {
            // Validaciones
            if (string.IsNullOrEmpty(modelo.NombreModelo))
                throw new Exception("El nombre es obligatorio");

            _repo.Add(modelo);
        }

        public void ActualizarModelo(Modelo modelo)
        {
            // Validaciones extra
            _repo.Update(modelo);
        }

        public void EliminarModelo(int? id)
        {
            _repo.Delete(id);
        }

    }
}
