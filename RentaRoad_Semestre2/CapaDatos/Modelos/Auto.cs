using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Auto
{
    public int IdAuto { get; set; }

    public int? FkDetalleAdquisicion { get; set; }

    public int? FkAdquisicion { get; set; }

    public int? FkMarca { get; set; }

    public int? FkModelo { get; set; }

    public int? FkColor { get; set; }

    public string? PlacaAuto { get; set; }

    public byte[]? ImagenAuto { get; set; }

    public decimal CostoRentaAuto { get; set; }

    public int AñoSalidaAuto { get; set; }

    public int CantidadAsientosAuto { get; set; }

    public bool NecesitaMantenimiento { get; set; }

    public bool EstaDisponibleAuto { get; set; }

    public bool EstaVerificadaPlacaAuto { get; set; }

    public bool EstaHabilitado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModficacion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual DetalleAdquisicion? DetalleAdquisicion { get; set; }

    public virtual ICollection<EntregaAuto> EntregaAutos { get; set; } = new List<EntregaAuto>();
}
