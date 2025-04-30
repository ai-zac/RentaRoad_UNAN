using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using Color = RentaRoad_Semestre3.CapaDatos.Modelos.Color;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class ColorServicio
    {
        private readonly ColorRepositorio _repo;

        public ColorServicio(ColorRepositorio repo)
        {
            _repo = repo;
        }

        public List<Color> ObtenerTodos()
        {
            return _repo.GetAllColors();
        }
        public Color? ObtenerPorID(int? id)
        {
            return ObtenerTodos().FirstOrDefault(c => c.IdColor == id);
        }

        public void CrearColor(Color color)
        {
            // Validaciones
            if (string.IsNullOrEmpty(color.NombreColor))
                throw new Exception("El nombre es obligatorio");

            _repo.Add(color);
        }

        public void ActualizarColor(Color color)
        {
            // Validaciones extra
            _repo.Update(color);
        }

        public void EliminarColor(int? id)
        {
            _repo.Delete(id);
        }
    }
}
