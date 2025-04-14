using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class RegistrosCaja
{
    public int IdRegistroCaja { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistroCaja { get; set; }

    public decimal EgresoTotalCordobas { get; set; }

    public decimal EgresoTotalDolares { get; set; }

    public decimal MontoInicial { get; set; }

    public decimal MontoFacturado { get; set; }

    public decimal MontoEgresado { get; set; }

    public decimal DesgloseTotalCordobas { get; set; }

    public decimal DesgloseTotalDolares { get; set; }
}
