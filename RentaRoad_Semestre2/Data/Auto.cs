using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

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

    public double CostoRenta { get; set; }

    public string Disponibilidad { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModficacion { get; set; }

    public string VerificacionPendiente { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<EntregaAuto> EntregaAutos { get; set; } = new List<EntregaAuto>();

    public virtual DetalleAdquisicion FkDetalleAdquisicionNavigation { get; set; } = null!;
}
