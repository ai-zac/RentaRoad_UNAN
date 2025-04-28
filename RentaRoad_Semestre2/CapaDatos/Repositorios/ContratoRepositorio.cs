using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class ContratoRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public ContratoRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Contrato> GetAll()
        {
            return _context.Contratos.ToList();
        }

        public Contrato? GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.IdContrato == id);
        }

        public void Add(Contrato contrato)
        {
            _context.Contratos.Add(contrato);
            _context.SaveChanges();
        }

        public void Update(Contrato contrato)
        {
            _context.Contratos.Update(contrato);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = GetById(id);
            if (c != null)
            {
                _context.Contratos.Remove(c);
                _context.SaveChanges();
            }
        }

    }
}
