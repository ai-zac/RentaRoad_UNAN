using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class Adquisicion
{
    public int IdAdquisicion { get; set; }

    public int FkProveedor { get; set; }

    public DateOnly FechaAdquisicion { get; set; }

    public double PrecioTotal { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();

    public virtual Proveedor FkProveedorNavigation { get; set; } = null!;
}
