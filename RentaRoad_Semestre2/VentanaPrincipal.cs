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

namespace RentaRoad_Semestre3
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            menuNavegacion.Renderer = new customRenderer();
        }

        private class customRenderer : ToolStripProfessionalRenderer
        {
            public customRenderer() : base(new customColorsRender()) { }
        }

        private class customColorsRender : ProfessionalColorTable
        {
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DimGray; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DimGray; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.DimGray; }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.DimGray; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.DimGray; }
            }
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
            {
                item.BackColor = Color.FromArgb(56, 62, 70);
            }
        }

        private Form activarForm = null;
        private void AbrirFormhija(Form Formhijo)
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

        public Form activeForm;
        private void AbrirFormHija(Form formhija)
        {
            activeForm = formhija;
            activeForm.ShowDialog();
        }

        private void optionRenta_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormhija(new Renta());
        }

        private void optionRegistroPlaca_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new RegistroPlacaAuto());
        }

        private void optionAdquisicion_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormhija(new Adquisiciones());
        }

        private void optionCaja_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new Caja());
        }

        private void optionMantenimiento_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new Mantenimiento());
        }

        private void optionProveedores_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new ControlProveedores());
        }

        private void optionClientes_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormhija(new ControlCliente());
        }

        private void optionUsuarios_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormhija(new ControlUsuario());
        }

        private void optionEntregaAuto_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new EntregaAutoRentado());
        }

        private void optionSalidaGaraje_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new SalidaAutoGaraje());
        }

        private void optionAcerca_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new AcercaDe());
        }

        private void optionListaDeAutos_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHija(new ControlAutos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_login().Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
