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
        private RentaRoadDbContext context = new RentaRoadDbContext();
        private UsuarioRepositorio repo;

        public frm_Usuarios()
        {
            InitializeComponent();
            // Configurar el cursor de la BD
            repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);

            cmbCargoEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCargoEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection datosCmbCargo = new AutoCompleteStringCollection();
            List<CargoEmpleado> cargosEmpleadosDB = _usuarioService.ObtenerCargosEmpleados();
            foreach (CargoEmpleado cargo in cargosEmpleadosDB)
            {
                datosCmbCargo.Add(cargo.NombreCargo);
                cmbCargoEmpleado.Items.Add(cargo.NombreCargo);
            }
            cmbCargoEmpleado.AutoCompleteCustomSource = datosCmbCargo;

            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            context = new RentaRoadDbContext();
            repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);

            dgListaUsuarios.Rows.Clear();
            var lista = _usuarioService.ObtenerTodos();
            foreach (var usuario in lista)
            {
                string nombreCargo = _usuarioService.ObtenerTodos().FirstOrDefault(u => u.IdUsuario == usuario.IdUsuario).IdCargoEmpleadoNavigation.NombreCargo;
                var fila = new DataGridViewRow();
                dgListaUsuarios.Rows.Add(
                    usuario.IdUsuario,
                    usuario.EsAdministrador,
                    nombreCargo,
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
            var idCargoEmpleado = _usuarioService.ObtenerCargo(cmbCargoEmpleado.SelectedItem.ToString()).IdCargoEmpleado;

            try
            {
                var usua = new Usuario
                {
                    IdCargoEmpleado = idCargoEmpleado,
                    CedulaUsuario = txtCedulaUsuario.Text,
                    NombreUsuario = txtNombreUsuario.Text,
                    TelefonoUsuario = int.Parse(txtTelefonoUsuario.Text),
                    ContraseñaUsuario = txtContraseña.Text,
                    CorreoUsuario = txtCorreoUsuario.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                    EstaHabilitado = true,
                    EsAdministrador = chbEsAdministrador.Checked,
                };
                MessageBox.Show("Cargar usuario.");

                _usuarioService.CrearUsuario(usua);
                MessageBox.Show("Usuario agregado.");
                actualizarDatagrid(); // refresca la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Editando los datos de usuarios directamente desde el datagrid en modo edicion
        private void dgListaUsuarios_actualizarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgListaUsuarios.Rows[e.RowIndex];

            int idUsuarioActual = (int)filaActual.Cells["dgIdUsuario"].Value;
            Usuario? usuaExistente = _usuarioService.ObtenerTodos()
                                    .FirstOrDefault(p => p.IdUsuario == idUsuarioActual);
            if (usuaExistente == null)
            {
                MessageBox.Show("El usuario no existe en la base de datos");
                return;
            }

            // Buscar si existe el cargo de empleado editado en el datagrid
            string? cargoEmpleadoDG = filaActual.Cells["dgCargoEmpleado"].Value.ToString();
            CargoEmpleado? cargoNuevo = _usuarioService.ObtenerCargosEmpleados().FirstOrDefault(c => c.NombreCargo == cargoEmpleadoDG);
            if (cargoNuevo == null)
            {
                MessageBox.Show("El cargo de empleado especificado no existe");
                return;
            }


            usuaExistente.NombreUsuario = filaActual.Cells["dgNombreUsuario"].Value.ToString();
            usuaExistente.TelefonoUsuario = (int)filaActual.Cells["dgTelefonoUsuario"].Value;
            usuaExistente.ContraseñaUsuario = filaActual.Cells["dgContraseñaUsuario"].Value.ToString();
            usuaExistente.CorreoUsuario = filaActual.Cells["dgCorreoUsuario"].Value.ToString();
            usuaExistente.FechaModificacion = DateTime.Now;
            usuaExistente.EstaHabilitado = bool.Parse(filaActual.Cells["dgEstadoUsuario"].Value.ToString());

            try
            {
                _usuarioService.ActualizarUsuario(usuaExistente);
                _usuarioService.ActualizarCargoEmpleado(usuaExistente, cargoNuevo);
                MessageBox.Show("Usuario actualizado.");
                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        // Eliminar un usuario dando click a la ultima celda de la fila
        private void dgListaUsuarios_eliminarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            // La ultima fila es para la funcionalidad de eliminar
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
