using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RentaRoad_Semestre3.CapaPresentacion;

namespace RentaRoad_Semestre3
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public Form activeForm;
        private void AbrirFormHija(Form formhija)
        {
            activeForm = formhija;
            activeForm.ShowDialog();
        }

        private void BtnFormGaraje_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ControlAutos());
        }

        private void BtnFormRenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Renta());
        }

        private void BtnFormPagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RegistroPlacaAuto());
        }

        private void BtnFormAdquisicion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Adquisiciones());
        }

        private void BtnFormCaja_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new Caja());
        }

        private void BtnFormMantenimiento_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new Mantenimiento());
        }

        private void BtnFormProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ControlProveedores());
        }

        private void BtnFormClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ControlCliente());
        }

        private void BtnFormUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ControlUsuario());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFormAcerca_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new AcercaDe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_login().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnFormEntregaAuto_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new EntregaAutoRentado());
        }

        private void BtnFormSalidaGaraje_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new SalidaAutoGaraje());
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
