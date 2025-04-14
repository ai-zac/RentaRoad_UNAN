using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class DetalleAdquisicion
{
    public int IdDetalleAdquisicion { get; set; }

    public int FkAdquisicion { get; set; }

    public int FkMarca { get; set; }

    public int FkModelo { get; set; }

    public int FkColor { get; set; }

    public decimal PrecioUnidadAuto { get; set; }

    public int CantidadAuto { get; set; }

    public decimal PrecioGrupalAuto { get; set; }

    public virtual Color FkColorNavigation { get; set; } = null!;

    public virtual Marca FkMarcaNavigation { get; set; } = null!;

    public virtual Modelo FkModeloNavigation { get; set; } = null!;
}
