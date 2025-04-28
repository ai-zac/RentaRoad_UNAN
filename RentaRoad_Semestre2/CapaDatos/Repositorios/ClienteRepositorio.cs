using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios
{
    internal class ClienteRepositorio
    {
        private readonly RentaRoadDbContext _context;

        public ClienteRepositorio(RentaRoadDbContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAllClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente? GetByCedula(string cedula)
        {
            return GetAllClientes().FirstOrDefault(c => c.CedulaCliente == cedula);
        }

        public void Add(Cliente clien)
        {
            _context.Clientes.Add(clien);
            _context.SaveChanges();
        }

        public void Update(Cliente clien)
        {
            _context.Clientes.Update(clien);
            _context.SaveChanges();
        }

        public void Delete(string cedula)
        {
            var c = GetByCedula(cedula);
            if (c != null)
            {
                _context.Clientes.Remove(c);
                _context.SaveChanges();
            }
        }
    }
}