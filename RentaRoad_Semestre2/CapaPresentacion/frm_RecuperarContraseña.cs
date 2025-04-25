using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
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
            if (txtCorreo.Text == null) return;

            Usuario? usuaExistente = _usuarioService.ObtenerTodos()
                                    .FirstOrDefault(u => u.CorreoUsuario == txtCorreo.Text);
            if (usuaExistente == null)
            {
                MessageBox.Show("El correo no existe en la base de datos");
                return;
            }

            string tokenRecuperacion = Guid.NewGuid().ToString();

            usuaExistente.TokenRecuperacion = tokenRecuperacion;
            usuaExistente.FechaLimiteRecuperacion = DateTime.Now.AddMinutes(5);
            _usuarioService.ActualizarUsuario(usuaExistente);

            if (enviarCorreo(txtCorreo.Text, tokenRecuperacion))
            {
                panelCorreo.Visible = false;
                return;
            }

        }

        private void btnToken_Click(object sender, EventArgs e)
        {

        }

        private bool enviarCorreo(string correoDestino, string token)
        {
            SmtpClient stmp = null;
            try
            {
                stmp = new SmtpClient("smtp.zoho.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("rentaroad_unan@zohomail.com", "6q2ei6eMCUfa"),
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al configurar el cliente");
                return false;
            }

            string asuntoCorreo = "Recuperación de contraseña";
            string cuerpoCorreo = $"Tu código de recuperación: {token}";

            try
            { 
                var mensajeCorreo = new MailMessage
                {
                    From = new MailAddress("rentaroad_unan@zohomail.com"),
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
                return false;
            }
            return true;
        }
    }
}
