using RentaRoad_Semestre3.Data;
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

        public class Proveedores
            {
            public List<Proveedores> ListarProveedores()
            {
                try
                {
                    using (var _contexto=new BillifyDbContext())

                    {
                        return _contexto.Proveedores.Tolist();
                    }
                }

                catch (Exception ex) 
                { 
                Console.WriteLine(ex.Message);
                    return new List<Proveedores>();
                }
            }
            public bool AgregarProveedor()
            {
            if (Proveedor == null)
                    Console.WriteLine("El proveedor no puede ser null");
            return false;

                try
                {
                    using (var _Contexto = new RentaRoadContext())
                    {
                        _Contexto.proveedores.Add(Proveedor);
                        _Contexto.SaveChanges();
                        return true;
                    }
                }

                catch (Exception ex) 
                {

                }
            }
    }
}
