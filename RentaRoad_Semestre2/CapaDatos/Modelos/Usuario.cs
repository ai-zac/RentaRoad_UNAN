using System;
using System.Collections.Generic;

namespace RentaRoad_Semestre3.CapaDatos.Modelos;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdCargoEmpleado { get; set; }

    public string CedulaUsuario { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int TelefonoUsuario { get; set; }

    public string ContraseñaUsuario { get; set; } = null!;

    public string CorreoUsuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool EstaHabilitado { get; set; }

    public bool EsAdministrador { get; set; }

    public string? TokenRecuperacion { get; set; }

    public DateTime? FechaLimiteRecuperacion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual CargoEmpleado IdCargoEmpleadoNavigation { get; set; } = null!;

    public virtual ICollection<RegistrosAperturasCaja> RegistrosAperturasCajas { get; set; } = new List<RegistrosAperturasCaja>();

    public virtual ICollection<RegistrosArqueosCaja> RegistrosArqueosCajas { get; set; } = new List<RegistrosArqueosCaja>();
}
