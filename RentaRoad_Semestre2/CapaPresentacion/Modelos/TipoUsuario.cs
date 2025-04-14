using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
