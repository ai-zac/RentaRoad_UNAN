using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string Tipo { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
