using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;

namespace RentaRoad_Semestre3.CapaNegocio;

public class ProveedorServicio 
{
    private readonly ProveedorRepositorio _repo;

    public ProveedorServicio(ProveedorRepositorio repo)
    {
        _repo = repo;
    }

    public List<Proveedor> ObtenerTodosProveedores()
    {
        return _repo.GetAllProveedores();
    }

    public Proveedor? ObtenerProveedorPorTelefono(string telefono)
    {
        return _repo.GetAllProveedores().FirstOrDefault(p => p.TelefonoProveedor == telefono);
    }

    public void CrearProveedor(Proveedor provee)
    {
        _repo.Add(provee);
    }

    public void ActualizarProveedor(Proveedor provee)
    {
        _repo.Update(provee);
    }

    public void EliminarProveedor(string RUC)
    {
        _repo.Delete(RUC);
    }
}
