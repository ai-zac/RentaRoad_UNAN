using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class MarcaRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public MarcaRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Marca> GetAllMarcas()
        {
            return _context.Marcas.ToList();
        }

        public Marca? GetById(int? id)
        {
            return GetAllMarcas().FirstOrDefault(c => c.IdMarca == id);
        }

        public void Add(Marca marca)
        {
            _context.Marcas.Add(marca);
            _context.SaveChanges();
        }

        public void Update(Marca marca)
        {
            _context.Marcas.Update(marca);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var c = GetById(id);
            if (c != null)
            {
                _context.Marcas.Remove(c);
                _context.SaveChanges();
            }
        }

    }
}
