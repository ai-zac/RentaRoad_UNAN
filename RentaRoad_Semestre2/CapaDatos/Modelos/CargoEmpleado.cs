using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class CargoEmpleado
{
    public int IdCargoEmpleado { get; set; }

    public string NombreCargo { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool EstaHabilitado { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
