using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using RentaRoad_Semestre3.CapaDatos.Modelos;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_Usuarios : Form
    {
        private UsuariosService _usuarioService;

        public frm_Usuarios()
        {
            InitializeComponent();

            // Configurar el cursor de la BD
            RentaRoadDbContext context = new RentaRoadDbContext();
            UsuarioRepositorio repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            // Configuracion del autocompletado en el buscador de cargos de empleados
            cmbCargoEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCargoEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection customSourceCmbCargo = new AutoCompleteStringCollection();
            List<CargoEmpleado> cargosDB = _usuarioService.ObtenerCargosEmpleados();
            foreach (CargoEmpleado cargoDB in cargosDB)
            {
                customSourceCmbCargo.Add(cargoDB.NombreCargo);
                cmbCargoEmpleado.Items.Add(cargoDB.NombreCargo);
            }
            cmbCargoEmpleado.AutoCompleteCustomSource = customSourceCmbCargo;

            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            /* Actualizar la lista de usuarios en el datagrid */ 
            dgListaUsuarios.Rows.Clear();
            List<Usuario> lista = _usuarioService.ObtenerTodos();
            foreach (Usuario usuario in lista)
            {
                dgListaUsuarios.Rows.Add(
                    usuario.IdUsuario,
                    usuario.EsAdministrador,
                    usuario.IdCargoEmpleadoNavigation.NombreCargo,
                    usuario.CedulaUsuario,
                    usuario.NombreUsuario,
                    usuario.TelefonoUsuario,
                    usuario.CorreoUsuario,
                    usuario.ContraseñaUsuario,
                    usuario.EstaHabilitado);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            /* Evento cuando se crea un usuario desde los controles */

            int idCargoEmpleado = _usuarioService.ObtenerCargo(cmbCargoEmpleado.SelectedItem.ToString()).IdCargoEmpleado;
            try
            {
                Usuario usua = new Usuario
                {
                    IdCargoEmpleado = idCargoEmpleado,
                    CedulaUsuario = txtCedulaUsuario.Text,
                    NombreUsuario = txtNombreUsuario.Text,
                    TelefonoUsuario = int.Parse(txtTelefonoUsuario.Text),
                    ContraseñaUsuario = txtContraseña.Text,
                    CorreoUsuario = txtCorreoUsuario.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                    EstaHabilitado = chbEstaHabilitado.Checked,
                    EsAdministrador = chbEsAdministrador.Checked,
                };
                MessageBox.Show("Cargar usuario.");

                _usuarioService.CrearUsuario(usua);
                MessageBox.Show("Usuario agregado.");

                actualizarDatagrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgListaUsuarios_actualizarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            /* Editando los datos de un usuario directamente desde el datagrid en modo edicion */

            DataGridViewRow filaActual = dgListaUsuarios.Rows[e.RowIndex];

            int idUsuarioActual = (int)filaActual.Cells["dgIdUsuario"].Value;
            Usuario? usuaExistente = _usuarioService.ObtenerTodos()
                                    .FirstOrDefault(p => p.IdUsuario == idUsuarioActual);
            if (usuaExistente == null)
            {
                MessageBox.Show("El usuario no existe en la base de datos");
                return;
            }

            // Validar la existencia del cargo escrito por el usuario en el datagrid
            string? cargoEmpleadoDG = filaActual.Cells["dgCargoEmpleado"].Value.ToString();
            CargoEmpleado? cargoNuevo = _usuarioService.ObtenerCargosEmpleados().FirstOrDefault(c => c.NombreCargo == cargoEmpleadoDG);
            if (cargoNuevo == null)
            {
                MessageBox.Show("El cargo de empleado especificado no existe");
                return;
            }

            usuaExistente.NombreUsuario = filaActual.Cells["dgNombreUsuario"].Value.ToString();
            usuaExistente.IdCargoEmpleado = cargoNuevo.IdCargoEmpleado;
            usuaExistente.IdCargoEmpleadoNavigation = cargoNuevo;
            usuaExistente.TelefonoUsuario = (int)filaActual.Cells["dgTelefonoUsuario"].Value;
            usuaExistente.ContraseñaUsuario = filaActual.Cells["dgContraseñaUsuario"].Value.ToString();
            usuaExistente.CorreoUsuario = filaActual.Cells["dgCorreoUsuario"].Value.ToString();
            usuaExistente.FechaModificacion = DateTime.Now;
            usuaExistente.EstaHabilitado = bool.Parse(filaActual.Cells["dgEstadoUsuario"].Value.ToString());

            try
            {
                _usuarioService.ActualizarUsuario(usuaExistente);
                MessageBox.Show("Usuario actualizado.");

                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void dgListaUsuarios_eliminarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            /* Eliminar un usuario dando click a la ultima celda de la fila */

            // La ultima columna es para la funcionalidad de eliminar el usuario de x fila
            if (e.ColumnIndex == dgListaUsuarios.ColumnCount - 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de eliminar?", "Confirmar",
                                 MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.No)
                    return;

                DataGridViewRow fila_actual = dgListaUsuarios.Rows[e.RowIndex];
                int IdUsuario = (int)fila_actual.Cells["dgIdUsuario"].Value;

                try
                {
                    _usuarioService.EliminarUsuario(IdUsuario);
                    MessageBox.Show("Usuario eliminado.");
                    actualizarDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgListaUsuarios_seleccionarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            /* Poblar los controles con los datos de la fila que se le dio click en el datagrid */

            DataGridViewRow filaActual = dgListaUsuarios.Rows[e.RowIndex];

            int idUsuarioActual = (int)filaActual.Cells["dgIdUsuario"].Value;
            Usuario? usuaExistente = _usuarioService.ObtenerTodos()
                                    .FirstOrDefault(p => p.IdUsuario == idUsuarioActual);

            cmbCargoEmpleado.SelectedItem = filaActual.Cells["dgCargoEmpleado"].Value.ToString();
            txtCedulaUsuario.Text = filaActual.Cells["dgCedulaUsuario"].Value.ToString();
            txtNombreUsuario.Text = filaActual.Cells["dgNombreUsuario"].Value.ToString();
            txtTelefonoUsuario.Text = filaActual.Cells["dgTelefonoUsuario"].Value.ToString();
            txtContraseña.Text = filaActual.Cells["dgContraseñaUsuario"].Value.ToString();
            txtCorreoUsuario.Text = filaActual.Cells["dgCorreoUsuario"].Value.ToString();
            chbEsAdministrador.Checked = bool.Parse(filaActual.Cells["dgTipoUsuario"].Value.ToString());
            chbEstaHabilitado.Checked = bool.Parse(filaActual.Cells["dgEstadoUsuario"].Value.ToString());
        }
    }
}
