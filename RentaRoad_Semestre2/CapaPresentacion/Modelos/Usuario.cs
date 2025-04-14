using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class Usuario
{
    public int FkTipoUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int FkCargoEmpleado { get; set; }

    public string CedulaUsuario { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int TelefonoUsuario { get; set; }

    public string Contraseña { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual CargoEmpleado FkCargoEmpleadoNavigation { get; set; } = null!;

    public virtual TipoUsuario FkTipoUsuarioNavigation { get; set; } = null!;
}
