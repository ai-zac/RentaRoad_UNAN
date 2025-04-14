using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class Auto
{
    public int IdAuto { get; set; }

    public int FkDetalleAdquisicion { get; set; }

    public int FkMarca { get; set; }

    public int FkModelo { get; set; }

    public int FkColor { get; set; }

    public string? Placa { get; set; }

    public int AñoSalida { get; set; }

    public int NumeroAsientos { get; set; }

    public string EstadoAuto { get; set; } = null!;

    public decimal CostoRenta { get; set; }

    public string Disponibilidad { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModficacion { get; set; }

    public string VerificacionPendiente { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
