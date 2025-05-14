using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class Egreso
{
    public int IdEgresos { get; set; }

    public string NombreEgreso { get; set; } = null!;

    public DateTime FechaAgreso { get; set; }

    public string DescripcionEgresos { get; set; } = null!;

    public double MontoEgreso { get; set; }
}
