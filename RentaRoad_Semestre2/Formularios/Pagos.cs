using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaRoad_Semestre3.Formularios.Subformularios;

namespace RentaRoad_Semestre3.Formularios
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeleccionContrato().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new SeleccionContrato().ShowDialog();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            new FormularioPagoTarjetaCredito().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new SeleccionContrato().ShowDialog();
        }
    }
}
