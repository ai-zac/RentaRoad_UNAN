using RentaRoad_Semestre3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaRoad_Semestre3.Formularios
{
    public partial class ControlProveedores : Form
    {
        private Proveedor? Proveedor;
        private Bindinglist<Proveedor>? ListaProveedores;
        public ControlProveedores()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Proveedor? proveedor;
        private void CargarProveedor()
        {
            Proveedor = new Proveedor();
            DtgProveedor.DataSource
        }

        private void CargarProveedores()
        {
            proveedor = new Proveedor();
            ListaProveedores = new BindingList<Proveedor>(Proveedor.Pro);
            DtgProveedor.DataSource = proveedor;
        }
        private void ControlProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ProveedorExistente = Proveedor.listar
        }
    }
}
