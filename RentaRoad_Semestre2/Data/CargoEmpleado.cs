using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class CargoEmpleado
{
    public int IdCargoEmpleado { get; set; }

    public string Cargo { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
