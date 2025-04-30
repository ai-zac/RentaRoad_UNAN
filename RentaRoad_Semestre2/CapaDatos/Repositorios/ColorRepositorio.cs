using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using Color = RentaRoad_Semestre3.CapaDatos.Modelos.Color;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class ColorRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public ColorRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Color> GetAllColors()
        {
            return _context.Colors.ToList();
        }

        public Color? GetById(int? id)
        {
            return GetAllColors().FirstOrDefault(c => c.IdColor == id);
        }

        public void Add(Color color)
        {
            _context.Colors.Add(color);
            _context.SaveChanges();
        }

        public void Update(Color color)
        {
            _context.Colors.Update(color);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var c = GetById(id);
            if (c != null)
            {
                _context.Colors.Remove(c);
                _context.SaveChanges();
            }
        }


    }
}
