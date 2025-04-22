using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Proveedor
{
    public string RucProveedor { get; set; } = null!;

    public string NombreProveedor { get; set; } = null!;

    public string TelefonoProveedor { get; set; } = null!;

    public string CorreoProveedor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool EstaHabilitado { get; set; }

    public virtual ICollection<Adquisicion> Adquisicions { get; set; } = new List<Adquisicion>();
}
