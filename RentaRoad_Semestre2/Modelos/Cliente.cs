using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.Modelos;

public partial class Cliente
{
    public string CedulaCliente { get; set; } = null!;

    public string NombreCliente { get; set; } = null!;

    public string TelefonoCliente { get; set; } = null!;

    public string DireccionViviendaCliente { get; set; } = null!;

    public string CodigoLicenciaConducir { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
