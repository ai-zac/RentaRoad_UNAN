using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class RegistrosAperturasCaja
{
    public int IdRegistroAperturaCaja { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaAperturaCaja { get; set; }

    public decimal MontoInicial { get; set; }

    public double TazaCambio { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
