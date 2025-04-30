using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Contrato
{
    public int IdContrato { get; set; }

    public string FkCedulaCliente { get; set; } = null!;

    public int FkAuto { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaCreacionContrato { get; set; }

    public string TipoPagoContrato { get; set; } = null!;

    public decimal MontoTotalContrato { get; set; }

    public int CantidadDiasRentaContrato { get; set; }

    public decimal MontoGarantiaContrato { get; set; }

    public decimal PorcentajeDescuentoContrato { get; set; }

    public bool EstaFinalizadoContrato { get; set; }

    public virtual Auto FkAutoNavigation { get; set; } = null!;

    public virtual Cliente FkCedulaClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
