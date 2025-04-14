using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaPresentacion.Modelos;

public partial class Contrato
{
    public int IdContrato { get; set; }

    public string FkCedulaCliente { get; set; } = null!;

    public int FkAuto { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string TipoPago { get; set; } = null!;

    public decimal MontoTotal { get; set; }

    public int PlazoAlquiler { get; set; }

    public decimal MontoGarantiaContrato { get; set; }

    public decimal PorcentajeDescuento { get; set; }

    public byte[] RutaFirma { get; set; } = null!;

    public string EstadoContrato { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public virtual Cliente FkCedulaClienteNavigation { get; set; } = null!;
}
