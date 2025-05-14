using RentaRoad_Semestre3.CapaNegocio;
using RentaRoad_Semestre3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class Egresos : Form
    {
        private ServicioEgresos? servicioEgresos;
        private BindingList<Egreso>? EgresosList; // Cambiar el tipo a Egreso


        public Egresos()
        {
            InitializeComponent();
        }

        

        private void Egresos_Load_1(object sender, EventArgs e)
        {
            cargarEgresos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicioEgresos == null)
                    servicioEgresos = new ServicioEgresos();

                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt1_Monto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Fecha.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                if (!double.TryParse(txt1_Monto.Text, out double monto))
                {
                    MessageBox.Show("El monto debe ser un número válido.");
                    return;
                }

                if (!DateTime.TryParse(txt_Fecha.Text, out DateTime fecha))
                {
                    MessageBox.Show("La fecha ingresada no es válida. Use el formato: dd/MM/yyyy.");
                    return;
                }

                var nuevoEgreso = new Egreso
                {
                    NombreEgreso = txt_Nombre.Text,
                    FechaAgreso = fecha,
                    DescripcionEgresos = txt_Direccion.Text,
                    MontoEgreso = monto
                };

                servicioEgresos.AgregarEgreso(nuevoEgreso);

                MessageBox.Show("Egreso agregado correctamente");

                cargarEgresos(); // Recargar la tabla

                // Limpiar campos
                txt_Nombre.Clear();
                txt_Direccion.Clear();
                txt1_Monto.Clear();
                txt_Fecha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el egreso: " + ex.Message);
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cargarEgresos()
        {
            try
            {
                servicioEgresos = new ServicioEgresos();

                // Cambiar el tipo de la lista para que coincida con el tipo esperado por BindingList  
                var listaEgresos = servicioEgresos.ListarEgresos();
                EgresosList = new BindingList<Egreso>(listaEgresos); // Cambiar el tipo de BindingList a Egreso

                dgt_Agresos.DataSource = EgresosList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los egresos");
            }
        }
    }
}
// Si quieres usar el modelo directamente:

