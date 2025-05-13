using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class Color
{
    public int IdColor { get; set; }

    public string NombreColor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificado { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();
}
