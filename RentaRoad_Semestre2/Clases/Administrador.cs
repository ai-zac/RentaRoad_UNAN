using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    internal class Administrador : Usuario
    {
        private int idAdminstrador;

        public int IdAdministrador { get; set; }

        public Administrador(string nombreInser, string apellidosInser, string correoInser, string numeroInser, string nombreUsuarioInser, string contraseñaInser, string tipoUsuarioInser
            ) 
            : base(nombreInser, apellidosInser, correoInser, numeroInser, nombreUsuarioInser, contraseñaInser, tipoUsuarioInser)
        {
            NombreUsuario = nombreUsuarioInser;
            Contraseña = contraseñaInser;
            TipoUsuario = tipoUsuarioInser;
        }
    }
}
