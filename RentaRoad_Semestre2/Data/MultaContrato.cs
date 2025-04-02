using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class MultaContrato
{
    public int IdMultaContrato { get; set; }

    public int FkContrato { get; set; }

    public double MontoMora { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public double FechaModificacion { get; set; }

    public int CantidadDiasDemora { get; set; }

    public virtual Contrato FkContratoNavigation { get; set; } = null!;
}
