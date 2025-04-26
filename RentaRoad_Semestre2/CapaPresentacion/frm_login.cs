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
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaPresentacion ;
using Microsoft.IdentityModel.Tokens;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_login : Form
    {
        private UsuariosService _usuarioService;

        public frm_login()
        {
            InitializeComponent();

            var context = new RentaRoadDbContext();
            var repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.IsNullOrEmpty() && txtContraseña.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Ambos campos están vacíos.");
                return;
            }
            else if (txtUsuario.Text.IsNullOrEmpty())
            {
                MessageBox.Show("El campo de usuario esta vacío.");
                return;
            }
            else if (txtContraseña.Text.IsNullOrEmpty())
            {
                MessageBox.Show("El campo de contraseña esta vacío.");
                return;
            }

            string nombreInsertado = txtUsuario.Text;
            string contraseñaInsertada = txtContraseña.Text;

            Usuario? usuarioEncontrado = _usuarioService.ObtenerTodos()
                .FirstOrDefault(u => u.NombreUsuario == nombreInsertado);
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            if (usuarioEncontrado.ContraseñaUsuario != contraseñaInsertada)
            {
                MessageBox.Show("Contraseña no es la correcta.");
                return;
            }

            this.Hide();
            Form frmHome = new frm_Home(usuarioEncontrado);
            frmHome.Closed += (s, args) => this.Close();
            frmHome.Show();
        }

        private void btnRecuperarContraseña_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frm_RecuperarContraseña().ShowDialog();
        }
    }
}
