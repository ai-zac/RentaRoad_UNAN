using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class EntregaAuto
{
    public int IdEntregaAuto { get; set; }

    public int FkAuto { get; set; }

    public DateTime FechaEntrega { get; set; }

    public string MotivoEntrega { get; set; } = null!;

    public string EstadoAuto { get; set; } = null!;

    public decimal CostoMantenimiento { get; set; }

    public virtual Auto FkAutoNavigation { get; set; } = null!;
}
