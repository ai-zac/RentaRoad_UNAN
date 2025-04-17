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
using RentaRoad_Semestre3.CapaPresentacion.Modelos;
using RentaRoad_Semestre3.CapaPresentacion.Subformularios;

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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string nombreInsertado = txtUsuario.Text;
            string contraseñaInsertada = txtContraseña.Text;

            Usuario? usuarioEncontrado = _usuarioService.ObtenerTodos()
                .FirstOrDefault(u => u.NombreUsuario == nombreInsertado);
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }

            if (usuarioEncontrado.Contraseña != contraseñaInsertada)
            {
                MessageBox.Show("Contraseña no es la correcta"); return;
                return;
            }

            new VentanaPrincipal().Show();
            this.Hide();
        }

        private void btnRecuperarContraseña_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RecuperarContraseña().ShowDialog();
        }
    }
}
