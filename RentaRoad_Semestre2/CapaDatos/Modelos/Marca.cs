using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string NombreMarca { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<DetalleAdquisicion> DetalleAdquisicions { get; set; } = new List<DetalleAdquisicion>();
}
