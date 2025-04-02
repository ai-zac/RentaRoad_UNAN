using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaRoad_Semestre3.Clases;

namespace RentaRoad_Semestre3
{
    static class ListaUsuarios
    {
        public static Dictionary<string, Usuario> lista;   

        static ListaUsuarios()
        {
            lista = new Dictionary<string, Usuario>();
            lista.Add("cajero1", new Usuario("Juan", "Zebedo Arguello", "jza@d.com", "+505 00001111", "cajero1", "123", "Empleado"));
            lista.Add("admin2", new Usuario("Pedro", "Aleman Altamirano", "paa@d.com", "+505 22223333", "admin2", "456", "Administrador"));
            lista.Add("empleado3", new Usuario("Mateo", "Balmaceda del Socorro", "mbs@d.com", "+505 33334444", "empleado3", "789", "Empleado"));
        }
    }
}
