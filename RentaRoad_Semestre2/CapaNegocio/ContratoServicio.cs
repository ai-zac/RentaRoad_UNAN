using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class ContratoServicio
    {
        private readonly ContratoRepositorio _repo;

        public ContratoServicio(ContratoRepositorio repo)
        {
            _repo = repo;
        }

        public List<Contrato> ObtenerTodos()
        {
            return _repo.GetAll();
        }

        public void CrearContrato(Contrato contrato)
        {
            _repo.Add(contrato);
        }

        public void ActualizarContrato(Contrato contrato)
        {
            // Validaciones extra
            _repo.Update(contrato);
        }

        public void EliminarContrato(int id)
        {
            _repo.Delete(id);
        }
    }
}
