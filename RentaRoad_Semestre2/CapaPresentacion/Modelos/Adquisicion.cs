using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class Adquisicion
{
    public int IdAdquisicion { get; set; }

    public int FkProveedor { get; set; }

    public DateTime FechaAdquisicion { get; set; }

    public decimal PrecioTotal { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual Proveedor FkProveedorNavigation { get; set; } = null!;
}
