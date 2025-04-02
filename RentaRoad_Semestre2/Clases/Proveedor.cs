using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    internal class Proveedor : Persona
    {
        private int idProvedor;
        protected string direccion;
        protected string nombreEmpresa;

        public int IdProveedor { get; }
        public string Direccion { get; set; }
        public string NombreEmpresa { get; set; }

        public Proveedor(string nombreInser, string apellidosInser, string correoInser, string numeroInser,
            string direccionInser, string nombreEmpresaInser) 
            : base(nombreInser, apellidosInser, correoInser, numeroInser)
        {
            Nombre = nombreInser;
            Apellidos = apellidosInser;
            Correo = correoInser;
            NumeroTelefono = numeroInser;
            Direccion = direccionInser;
            NombreEmpresa = nombreEmpresaInser;
        }
    }
}
