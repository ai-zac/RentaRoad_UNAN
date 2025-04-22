using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using System.Security.Cryptography.X509Certificates;
public class UsuariosService
{
    private readonly UsuarioRepositorio _repo;

    public UsuariosService(UsuarioRepositorio repo)
    {
        _repo = repo;
    }

    public CargoEmpleado ObtenerCargo(string Cargo)
    {
        return _repo.GetAllCargoEmpleado().FirstOrDefault(c => c.NombreCargo == Cargo);
    }

    public List<CargoEmpleado> ObtenerCargosEmpleados()
    {
        return _repo.GetAllCargoEmpleado();
    }

    public List<Usuario> ObtenerTodos()
    {
        return _repo.GetAllUsuarios();
    }

    public void CrearUsuario(Usuario usua)
    {
        // Validaciones
        if (string.IsNullOrEmpty(usua.NombreUsuario))
            throw new Exception("El nombre es obligatorio");

        _repo.Add(usua);
    }

    public void ActualizarUsuario(Usuario usua)
    {
        // Validaciones extra
        _repo.Update(usua);
    }

    public void ActualizarCargoEmpleado(Usuario usua, CargoEmpleado nuevoCargo)
    {
        _repo.ChangeCargoEmpleado(usua, usua.IdCargoEmpleadoNavigation, nuevoCargo);
    }

    public void EliminarUsuario(int Id)
    {
        _repo.Delete(Id);
    }
}

