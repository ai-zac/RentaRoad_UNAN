using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class AutoRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public AutoRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Auto> GetAllAutos()
        {
            return _context.Autos
                .Include(c => c.DetalleAdquisicion)
                .Include(c => c.DetalleAdquisicion.FkAdquisicionNavigation)
                .Include(c => c.DetalleAdquisicion.FkColorNavigation)
                .Include(c => c.DetalleAdquisicion.FkModeloNavigation)
                .Include(c => c.DetalleAdquisicion.FkMarcaNavigation)
                .ToList();
        }

        public Auto? GetByPlaca(string placa)
        {
            return GetAllAutos().FirstOrDefault(c => c.PlacaAuto == placa);
        }

        public void Add(Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();
        }

        public void Update(Auto auto)
        {
            _context.Autos.Update(auto);
            _context.SaveChanges();
        }

        public void Delete(string placa)
        {
            var c = GetByPlaca(placa);
            if (c != null)
            {
                _context.Autos.Remove(c);
                _context.SaveChanges();
            }
        }

    }
}
