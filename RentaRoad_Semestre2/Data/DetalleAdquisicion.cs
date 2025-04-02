using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class DetalleAdquisicion
{
    public int IdDetalleAdquisicion { get; set; }

    public int FkAdquisicion { get; set; }

    public int FkMarca { get; set; }

    public int FkModelo { get; set; }

    public int FkColor { get; set; }

    public double PrecioUnidadAuto { get; set; }

    public int CantidadAuto { get; set; }

    public double PrecioGrupalAuto { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public virtual ICollection<Auto> Autos { get; set; } = new List<Auto>();

    public virtual Adquisicion FkAdquisicionNavigation { get; set; } = null!;

    public virtual Color FkColorNavigation { get; set; } = null!;

    public virtual Marca FkMarcaNavigation { get; set; } = null!;

    public virtual Modelo FkModeloNavigation { get; set; } = null!;
}
