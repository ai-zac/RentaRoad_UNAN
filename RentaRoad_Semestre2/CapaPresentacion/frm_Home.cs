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
using System.Security.Cryptography.X509Certificates;
using RentaRoad_Semestre3.Herramientas;

namespace RentaRoad_Semestre3
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
            menuNavegacion.Renderer = new customRenderUIColors();
        }

        public ToolStripItem itemSeleccionado = null;
        private void indicarItemMenuSeleccionado(object objetoEvento)
        {
            if (itemSeleccionado != null)
            {
                itemSeleccionado.BackColor = Color.FromArgb(26, 32, 40);
                itemSeleccionado.ForeColor = Color.White;
            }

            ToolStripItemCollection menuItems = menuNavegacion.Items;
            foreach (ToolStripItem menuItem in menuItems)
            {
                menuItem.BackColor = Color.FromArgb(26, 32, 40);
                menuItem.ForeColor = Color.White;
            }

            ToolStripItem? item = (objetoEvento as ToolStripItem);
            itemSeleccionado = item;
            if (item != null)
                item.BackColor = Color.FromArgb(56, 62, 70);
        }


        private Form activarForm = null;
        private void AbrirFormHija(Form Formhijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            Formhijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(Formhijo);
            panelContenedor.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();

        }

        private void optionRenta_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Renta());
        }

        private void optionRegistroPlaca_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new RegistroPlacaAuto());
        }

        private void optionAdquisicion_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Adquisicion());
        }

        private void optionCaja_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Caja());
        }

        private void optionMantenimiento_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Matenimiento());
        }

        private void optionProveedores_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Proveedores());
        }

        private void optionClientes_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Clientes());
        }

        private void optionUsuarios_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new frm_Usuarios());
        }

        // GARAJE - opciones
        private void optionEntregaAuto_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);     
            AbrirFormHija(new frm_GarajeEntregaAutoRentado());
        }

        private void optionSalidaGaraje_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);     
            AbrirFormHija(new frm_GarajeSalida());
        }

        private void optionListaDeAutos_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);     
            AbrirFormHija(new frm_GarajeListaAutos());
        }
        // FINAL - GARAJE - opciones

        private void optionAcerca_Click(object sender, EventArgs e)
        {
            Form frmAcercaDe = new frm_AcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_login().Show();
        }
    }
}
