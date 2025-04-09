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
using RentaRoad_Semestre3.Clases;
using RentaRoad_Semestre3.Formularios;
namespace RentaRoad_Semestre3
{
    public partial class VentanaInicioSesion : Form
    {
        public VentanaInicioSesion()
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

        private void txtPass_Leave(object sender, EventArgs e) 
        {
            string contraseña = txtPass.Text;
            if (string.IsNullOrEmpty(contraseña) || string.IsNullOrWhiteSpace(contraseña))
                txtPass.Text = "Contraseña";
        }

        private void txtUser_Leave(object sender, EventArgs e) 
        { 
            string usuario = txtUser.Text;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
                txtUser.Text = "Usuario";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUser.Text;

            if (!ListaUsuarios.lista.ContainsKey(nombreUsuario)) 
            {
                MessageBox.Show("Usuario no existe");
                txtUser.Clear();
                return;
            }
            Usuario usuario = ListaUsuarios.lista[nombreUsuario];
            if (txtPass.Text != usuario.Contraseña)
            {
                MessageBox.Show("Contraseña incorrecta");
                txtPass.Clear();
                return;
            }

            Credenciales.usuarioActual = usuario;
            new VentanaPrincipal().Show();
            this.Hide();
        }

        private void VentanaInicioSesion_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();    

        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RecuperarContraseña().ShowDialog();
        }
    }
}
