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
    public partial class frm_Egreso : Form
    {
        private ServicioEgresos? servicioEgresos;
        private BindingList<Egreso>? EgresosList; // Cambiar el tipo a Egreso


        public frm_Egreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Egreso_Load(object sender, EventArgs e)
        {
            cargarEgresos();
        }

        private void cargarEgresos()
        {
            try
            {
                servicioEgresos = new ServicioEgresos();

                // Cambiar el tipo de la lista para que coincida con el tipo esperado por BindingList  
                var listaEgresos = servicioEgresos.ListarEgresos();
                EgresosList = new BindingList<Egreso>(listaEgresos); // Cambiar el tipo de BindingList a Egreso

                dgt_egresos.DataSource = EgresosList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los egresos");
            }
        }
    }
}
