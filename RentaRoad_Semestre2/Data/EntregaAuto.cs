using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class EntregaAuto
{
    public int IdEntregaAuto { get; set; }

    public int FkAuto { get; set; }

    public DateOnly FechaEntrega { get; set; }

    public string EstadoAuto { get; set; } = null!;

    public double CostoMantenimiento { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public virtual Auto FkAutoNavigation { get; set; } = null!;
}
