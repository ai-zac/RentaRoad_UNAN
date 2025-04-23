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
using RentaRoad_Semestre3.CapaDatos.Modelos;
using Color = System.Drawing.Color;

namespace RentaRoad_Semestre3
{
    public partial class frm_Home : Form
    {
        public frm_Home(Usuario usuarioLogeado)
        {
            InitializeComponent();
            menuNavegacion.Renderer = new customRenderUIColors();
            AbrirFormHijo(new frm_AperturaCaja());

            if (!usuarioLogeado.EsAdministrador)
            {
                optionUsuarios.Visible = false;
                optionMatenimiento.Visible = false;
            }

            mostrarMenusSegunCargo(usuarioLogeado.IdCargoEmpleadoNavigation);
        }

        /* MenuStrip - Menu de navegación, opciones
         */
        private void optionRenta_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Renta());
        }

        private void optionAdquisicion_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Adquisicion());
        }

        private void optionCaja_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Caja());
        }

        private void optionMantenimiento_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Matenimiento());
        }

        private void optionProveedores_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Proveedores());
        }

        private void optionClientes_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Clientes());
        }

        private void optionUsuarios_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            AbrirFormHijo(new frm_Usuarios());
        }

        // GARAJE - opciones
        private void optionEntregaAuto_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeEntregaAutoRentado());
        }

        private void optionSalidaGaraje_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeSalida());
        }

        private void optionListaDeAutos_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeListaAutos());
        }

        private void optionMarcas_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            optionCaracteristica.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeMarcas());
        }

        private void optionModelos_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            optionCaracteristica.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeModelos());
        }

        private void optionColores_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(sender);
            optionGaraje.BackColor = Color.FromArgb(56, 62, 70);
            optionCaracteristica.BackColor = Color.FromArgb(56, 62, 70);
            AbrirFormHijo(new frm_GarajeColores());
        }
        // FINAL - GARAJE - opciones

        private void optionAcerca_Click(object sender, EventArgs e)
        {
            Form frmAcercaDe = new frm_AcercaDe();
            frmAcercaDe.ShowDialog();
        }
        /* FINAL MenuStrip 
         */

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmLogin = new frm_login();
            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.Show();
        }

        private void tituloRentaRoad_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(null);
            AbrirFormHijo(new frm_AperturaCaja());
        }

        private void btnVolverHome_Click(object sender, EventArgs e)
        {
            indicarItemMenuSeleccionado(null);
            AbrirFormHijo(new frm_AperturaCaja());
        }


        public ToolStripItem? itemSeleccionado = null;
        private void indicarItemMenuSeleccionado(object? objetoEvento)
        {
            // Des-subrayar la opcion seleccionada previamente
            // En especial las subopciones o subitems 
            if (itemSeleccionado != null)
            {
                itemSeleccionado.BackColor = Color.FromArgb(26, 32, 40); // Azul opaco oscuro
                itemSeleccionado.ForeColor = Color.White;
            }

            ToolStripItemCollection menuItems = menuNavegacion.Items;
            foreach (ToolStripItem menuItem in menuItems)
            {
                menuItem.BackColor = Color.FromArgb(26, 32, 40); // Azul opaco oscuro
                menuItem.ForeColor = Color.White;
            }

            ToolStripItem? item = (objetoEvento as ToolStripItem);
            itemSeleccionado = item;
            if (item != null)
                item.BackColor = Color.FromArgb(56, 62, 70); // Azul opaco claro
        }

        private Form activarForm = null;
        private void AbrirFormHijo(Form Formhijo)
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

        private void mostrarMenusSegunCargo(CargoEmpleado Cargo)
        {
            switch (Cargo.NombreCargo)
            {
                case "Cajero":
                    optionGaraje.Visible = false;
                    optionProveedores.Visible = false;
                    optionAdquisiciones.Visible = false;
                    optionSalidaDeGaraje.Visible = false;
                    optionEntregaAuto.Visible = false;
                    optionCaracteristica.Visible = false;
                    break;

                case "Agente":
                    optionProveedores.Visible = false;
                    optionAdquisiciones.Visible = false;
                    optionSalidaDeGaraje.Visible = false;
                    optionEntregaAuto.Visible = false;
                    optionCaja.Visible = false;
                    break;

            }
        }
    }
}
