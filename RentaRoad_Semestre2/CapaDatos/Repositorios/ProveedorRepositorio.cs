using Microsoft.EntityFrameworkCore;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaDatos.Repositorios;

public class ProveedorRepositorio
{
    private readonly RentaRoadDbContext _context;

    public ProveedorRepositorio(RentaRoadDbContext context)
    {
        _context = context;
    }

    public List<Proveedor> GetAllProveedores()
    {
        return _context.Proveedors.ToList();

    }
    public Proveedor? GetByRUC(string RUC)
    {
        return _context.Proveedors.ToList().FirstOrDefault(p => p.RucProveedor == RUC);
    }

    public void Add(Proveedor prove)
    {
        _context.Proveedors.Add(prove);
        _context.SaveChanges();
    }

    public void Update(Proveedor prove)
    {
        _context.Proveedors.Update(prove);
        _context.SaveChanges();
    }

    public void Delete(string RUC)
    {
        // p = proveedor
        var p = GetByRUC(RUC);
        if (p != null)
        {
            _context.Proveedors.Remove(p);
            _context.SaveChanges();
        }
    }
}
