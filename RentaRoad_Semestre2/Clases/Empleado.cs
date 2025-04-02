using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    internal class Empleado : Usuario
    {
        private int idEmpleado;

        public int IdEmpleado { get; set; }

        public Empleado(string nombreInser, string apellidosInser, string correoInser, string numeroInser, string nombreUsuarioInser, string contraseñaInser, string tipoUsuarioInser
            ) 
            : base(nombreInser, apellidosInser, correoInser, numeroInser, nombreUsuarioInser, contraseñaInser, tipoUsuarioInser)
        {
            NombreUsuario = nombreUsuarioInser;
            Contraseña = contraseñaInser;
            TipoUsuario = tipoUsuarioInser;
        }

    }
}
