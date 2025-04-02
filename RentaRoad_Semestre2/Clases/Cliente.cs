using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    internal class Cliente : Persona
    {
        protected string cedula;

        public string Cedula { get; set; }

        public Cliente(string nombreInser, string apellidosInser, string correoInser, string numeroInser,
            string cedulaInser) 
            : base(nombreInser, apellidosInser, correoInser, numeroInser)
        {
            Nombre = nombreInser;
            Apellidos = apellidosInser;
            Correo = correoInser;
            NumeroTelefono = numeroInser;
            Cedula = cedulaInser;
        }

    }
}
