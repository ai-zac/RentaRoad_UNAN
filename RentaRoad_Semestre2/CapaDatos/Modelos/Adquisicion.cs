using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Adquisicion
{
    public int IdAdquisicion { get; set; }

    public string RucProveedor { get; set; } = null!;

    public DateTime FechaAdquisicion { get; set; }

    public decimal PrecioTotalAdquisicion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();

    public virtual Proveedor RucProveedorNavigation { get; set; } = null!;
}
