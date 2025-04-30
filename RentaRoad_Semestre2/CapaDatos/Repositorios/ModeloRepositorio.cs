using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class ModeloRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public ModeloRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Modelo> GetAllModelos()
        {
            return _context.Modelos.ToList();
        }

        public Modelo? GetById(int? id)
        {
            return GetAllModelos().FirstOrDefault(c => c.IdModelo == id);
        }

        public void Add(Modelo modelo)
        {
            _context.Modelos.Add(modelo);
            _context.SaveChanges();
        }

        public void Update(Modelo modelo)
        {
            _context.Modelos.Update(modelo);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var c = GetById(id);
            if (c != null)
            {
                _context.Modelos.Remove(c);
                _context.SaveChanges();
            }
        }


    }
}
