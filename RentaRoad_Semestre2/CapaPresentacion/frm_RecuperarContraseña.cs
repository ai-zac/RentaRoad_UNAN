using Microsoft.IdentityModel.Tokens;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using RentaRoad_Semestre3.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_RecuperarContraseña : Form
    {
        private UsuariosService _usuarioService;
        private Usuario? usuarioActual;

        public frm_RecuperarContraseña()
        {
            InitializeComponent();

            // Configurar el cursor de la BD
            RentaRoadDbContext context = new RentaRoadDbContext();
            UsuarioRepositorio repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.IsNullOrEmpty())
            {
                MessageBox.Show("El campo de correo esta vacio");
                return;
            }

            usuarioActual = _usuarioService.ObtenerTodos()
                                    .FirstOrDefault(u => u.CorreoUsuario == txtCorreo.Text.Trim());
            if (usuarioActual == null)
            {
                MessageBox.Show("El correo no existe en la base de datos");
                return;
            }

            string tokenRecuperacion = Guid.NewGuid().ToString();

            usuarioActual.TokenRecuperacion = tokenRecuperacion;
            usuarioActual.FechaLimiteRecuperacion = DateTime.Now.AddMinutes(1);
            _usuarioService.ActualizarUsuario(usuarioActual);

            if (enviarCorreo(txtCorreo.Text.Trim(), tokenRecuperacion))
            {
                panelCorreo.Visible = false;
                return;
            }

        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            if (usuarioActual.FechaLimiteRecuperacion < DateTime.Now)
            {
                MessageBox.Show("Se ha pasado del tiempo limite para ingresar el token");
                return;
            }

            string token = txtToken.Text.Trim();

            if (token.IsNullOrEmpty())
            {
                MessageBox.Show("El campo de token esta vacio");
                return;
            }

            if (usuarioActual.TokenRecuperacion != token)
            {
                MessageBox.Show("El token no es el correcto");
                return;
            }

            panelToken.Visible = false;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El campo de la contraseña esta vacio");
                return;
            }    

            usuarioActual.ContraseñaUsuario = txtContraseña.Text.Trim();
            usuarioActual.TokenRecuperacion = null;
            usuarioActual.FechaLimiteRecuperacion = null;
            _usuarioService.ActualizarUsuario(usuarioActual);

            MessageBox.Show("La contraseña ha sido actualizada correctamente");
            this.Close();
        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            usuarioActual.TokenRecuperacion = null;
            usuarioActual.FechaLimiteRecuperacion = null;
            _usuarioService.ActualizarUsuario(usuarioActual);

            panelCorreo.Visible = true;
            txtToken.Text = string.Empty;
        }


        private bool enviarCorreo(string correoDestino, string token)
        {
            string correoSalida = "rentaroad_unan@zohomail.com";
            string correoSalidaPass = "6q2ei6eMCUfa";

            SmtpClient stmp = new SmtpClient("smtp.zoho.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(correoSalida, correoSalidaPass),
                EnableSsl = true,
                UseDefaultCredentials = false
            };

            string asuntoCorreo = "Recuperación de contraseña";
            string cuerpoCorreo = $"Tu código de recuperación: {token}";

            try
            {
                var mensajeCorreo = new MailMessage
                {
                    From = new MailAddress(correoSalida),
                    Subject = asuntoCorreo,
                    Body = cuerpoCorreo,
                    IsBodyHtml = false
                };

                mensajeCorreo.To.Add(correoDestino);
                stmp.Send(mensajeCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar el correo");
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
