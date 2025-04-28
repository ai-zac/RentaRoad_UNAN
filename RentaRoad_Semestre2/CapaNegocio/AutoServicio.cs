using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class AutoServicio
    {
        private readonly AutoRepositorio _repo;

        public AutoServicio(AutoRepositorio repo)
        {
            _repo = repo;
        }

        public List<Auto> ObtenerTodos()
        {
            return _repo.GetAllAutos();
        }

        public Auto? ObtenerPorPlaca(string placa)
        {
            return _repo.GetByPlaca(placa); 
        }

        public void CrearAuto(Auto auto)
        {
            _repo.Add(auto);
        }

        public void ActualizarAuto(Auto auto)
        {
            _repo.Update(auto);
        }

        public void EliminarAuto(string placa)
        {
            _repo.Delete(placa);
        }

    }
}
