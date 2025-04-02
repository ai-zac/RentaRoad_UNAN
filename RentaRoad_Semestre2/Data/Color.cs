using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class Color
{
    public int IdColor { get; set; }

    public string Color1 { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificado { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();
}
