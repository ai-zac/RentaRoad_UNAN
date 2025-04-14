using RentaRoad_Semestre3.CapaPresentacion.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using System.Security.Cryptography.X509Certificates;
public class UsuariosService
{
    private readonly UsuarioRepositorio _repo;

    public UsuariosService(UsuarioRepositorio repo)
    {
        _repo = repo;
    }

    public List<TipoUsuario> ObtenerTiposUsuarios()
    {
        return _repo.GetAllTipoUsuario();
    }

    public TipoUsuario ObtenerTipo(string Tipo)
    {
        return _repo.GetAllTipoUsuario().FirstOrDefault(t => t.Tipo == Tipo);
    }

    public CargoEmpleado ObtenerCargo(string Cargo)
    {
        return _repo.GetAllCargoEmpleado().FirstOrDefault(c => c.Cargo == Cargo);
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

    public void ActualizarTipoUsuario(Usuario usua, TipoUsuario nuevoTipo)
    {
        _repo.ChangeTipoUsuarios(usua, usua.FkTipoUsuarioNavigation, nuevoTipo);
    }

    public void ActualizarCargoEmpleado(Usuario usua, CargoEmpleado nuevoCargo)
    {
        _repo.ChangeCargoEmpleado(usua, usua.FkCargoEmpleadoNavigation, nuevoCargo);
    }

    public void EliminarUsuario(int FkIdTipoUsuario, int Id, int FkIdCargoEmpleado)
    {
        _repo.Delete(FkIdTipoUsuario, Id, FkIdCargoEmpleado);
    }
}

