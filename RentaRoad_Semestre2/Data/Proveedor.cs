using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string TelefonoProveedor { get; set; } = null!;

    public string CorreoProveedor { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Adquisicion> Adquisicions { get; set; } = new List<Adquisicion>();
}
