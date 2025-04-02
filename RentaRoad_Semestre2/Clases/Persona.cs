using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Clases
{
    public class Persona
    {
        protected string nombre;
        protected string apellidos;
        protected string correo;
        protected string numeroTelefono;

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefono { get; set; }

        public Persona(string nombreInser, string apellidosInser, string correoInser, string numeroInser)
        { 
            Nombre = nombreInser;
            Apellidos = apellidosInser;
            Correo = correoInser;  
            NumeroTelefono = numeroInser;   
        }
    }
}
