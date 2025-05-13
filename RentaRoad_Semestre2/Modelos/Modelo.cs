using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class Modelo
{
    public int IdModelo { get; set; }

    public string NombreModelo { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();
}
