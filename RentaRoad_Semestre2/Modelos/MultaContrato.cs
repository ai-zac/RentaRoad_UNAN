using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class MultaContrato
{
    public int IdMultaContrato { get; set; }

    public int FkContrato { get; set; }

    public int IdUsuario { get; set; }

    public decimal MontoMora { get; set; }

    public int CantidadDiasDemora { get; set; }

    public string MotivoMulta { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }
}
