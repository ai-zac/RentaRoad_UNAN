using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    public class Usuario : Persona
    {
        private int idUsuario;
        protected string nombreUsuario;
        private string contraseña;
        protected string tipoUsuario;

        public int IdUsuario { get; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; }

        public Usuario(string nombreInser, string apellidosInser, string correoInser, string numeroInser,
            string nombreUsuarioInser, string contraseñaInser, string tipoUsuarioInser)
            : base(nombreInser, apellidosInser, correoInser, numeroInser)
        {
            NombreUsuario = nombreUsuarioInser;
            Contraseña = contraseñaInser;
            TipoUsuario = tipoUsuarioInser;

            IdUsuario = ListaUsuarios.lista.Count + 1;
        }

        protected void cambiarTipo(string tipo)
        { 
            TipoUsuario = tipo;
        }
    }
}
