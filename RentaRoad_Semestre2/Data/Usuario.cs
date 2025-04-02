using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int FkTipoUsuario { get; set; }

    public int FkCargoEmpleado { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? FechaCreacion { get; set; }

    public string? FechaModificacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual CargoEmpleado FkCargoEmpleadoNavigation { get; set; } = null!;

    public virtual TipoUsuario FkTipoUsuarioNavigation { get; set; } = null!;
}
