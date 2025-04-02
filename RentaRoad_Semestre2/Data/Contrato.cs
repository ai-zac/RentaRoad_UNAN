using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Data;

public partial class Contrato
{
    public int IdContrato { get; set; }

    public int FkUsuario { get; set; }

    public string FkCedulaCliente { get; set; } = null!;

    public int FkAuto { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public string TipoPago { get; set; } = null!;

    public double MontoTotal { get; set; }

    public double CambioMontoTotalContrato { get; set; }

    public int PlazoAlquiler { get; set; }

    public double PorcentajeDescuento { get; set; }

    public byte[] RutaFirma { get; set; } = null!;

    public string EstadoContrato { get; set; } = null!;

    public DateOnly FechaModificacion { get; set; }

    public virtual Auto FkAutoNavigation { get; set; } = null!;

    public virtual Cliente FkCedulaClienteNavigation { get; set; } = null!;

    public virtual Usuario FkUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<MultaContrato> MultaContratos { get; set; } = new List<MultaContrato>();
}
