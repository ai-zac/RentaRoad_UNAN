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
using RentaRoad_Semestre3.CapaPresentacion.Modelos;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class ControlUsuario : Form
    {
        private UsuariosService _usuarioService;

        public ControlUsuario()
        {
            InitializeComponent();
            // Configurar el cursor de la BD
            var context = new RentaRoadDbContext();
            var repo = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repo);

            cmbCargoEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCargoEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTipoUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            dgListaUsuarios.Columns.Add("dgIdUsuario", "ID");
            dgListaUsuarios.Columns.Add("dgTipoUsuario", "Tipo Usuario");
            dgListaUsuarios.Columns.Add("dgCargoEmpleado", "Cargo Empleado");
            dgListaUsuarios.Columns.Add("dgCedulaUsuario", "Cédula");
            dgListaUsuarios.Columns.Add("dgNombreUsuario", "Nombre usuario");
            dgListaUsuarios.Columns.Add("dgTelefonoUsuario", "Teléfono");
            dgListaUsuarios.Columns.Add("dgCorreoUsuario", "Correo Electrónico");
            dgListaUsuarios.Columns.Add("dgContraseñaUsuario", "Contraseña");
            dgListaUsuarios.Columns.Add("dgEstadoUsuario", "Estado");
            dgListaUsuarios.Columns.Add("dgEliminar", "Eliminar");

            AutoCompleteStringCollection datosCmbCargo = new AutoCompleteStringCollection();
            List<CargoEmpleado> cargosEmpleadosDB = _usuarioService.ObtenerCargosEmpleados();
            foreach (CargoEmpleado cargo in cargosEmpleadosDB)
            {
                datosCmbCargo.Add(cargo.Cargo);
                cmbCargoEmpleado.Items.Add(cargo.Cargo);
            }
            cmbCargoEmpleado.AutoCompleteCustomSource = datosCmbCargo;

            AutoCompleteStringCollection datosCmbTipos = new AutoCompleteStringCollection();
            List<TipoUsuario> tiposEmpleadosDB = _usuarioService.ObtenerTiposUsuarios();
            foreach (TipoUsuario tipo in tiposEmpleadosDB)
            {
                datosCmbTipos.Add(tipo.Tipo);
                cmbTipoUsuario.Items.Add(tipo.Tipo);
            }
            cmbTipoUsuario.AutoCompleteCustomSource = datosCmbTipos;


            actualizarDatagrid();
        }
 
        private void actualizarDatagrid()
        {
            dgListaUsuarios.Rows.Clear();
            var lista = _usuarioService.ObtenerTodos();
            foreach (var usuario in lista)
            {
                var fila = new DataGridViewRow();
                dgListaUsuarios.Rows.Add(
                    usuario.IdUsuario,
                    usuario.FkTipoUsuarioNavigation.Tipo,
                    usuario.FkCargoEmpleadoNavigation.Cargo,
                    usuario.CedulaUsuario,
                    usuario.NombreUsuario,
                    usuario.TelefonoUsuario,
                    usuario.Correo,
                    usuario.Contraseña,
                    usuario.Estado);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var idTipoUsuario = _usuarioService.ObtenerTipo(cmbTipoUsuario.SelectedItem.ToString()).IdTipoUsuario;
            var idCargoEmpleado = _usuarioService.ObtenerCargo(cmbCargoEmpleado.SelectedItem.ToString()).IdCargoEmpleado;

            try
            {
                var usua = new Usuario
                {
                    FkTipoUsuario = idTipoUsuario,
                    FkCargoEmpleado = idCargoEmpleado,
                    CedulaUsuario = txtCedulaUsuario.Text,
                    NombreUsuario = txtNombreUsuario.Text,
                    TelefonoUsuario = int.Parse(txtTelefonoUsuario.Text),
                    Contraseña = txtContraseña.Text,
                    Correo = txtCorreoUsuario.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                    Estado = "Habilitado",
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
            CargoEmpleado? cargoNuevo = _usuarioService.ObtenerCargosEmpleados().FirstOrDefault(c => c.Cargo == cargoEmpleadoDG);
            if (cargoNuevo == null)
            {
                MessageBox.Show("El cargo de empleado especificado no existe");
                return;
            }

            // Buscar si existe el tipo de usuario editado en el datagrid
            string? tipoUsuarioDG = filaActual.Cells["dgTipoUsuario"].Value.ToString();
            TipoUsuario? tipoNuevo = _usuarioService.ObtenerTiposUsuarios().FirstOrDefault(t => t.Tipo == tipoUsuarioDG);
            if (tipoNuevo == null)
            {
                MessageBox.Show("El tipo de usuario especificado no existe");
                return;
            }

            usuaExistente.NombreUsuario = filaActual.Cells["dgNombreUsuario"].Value.ToString();
            usuaExistente.TelefonoUsuario = (int)filaActual.Cells["dgTelefonoUsuario"].Value;
            usuaExistente.Contraseña = filaActual.Cells["dgContraseñaUsuario"].Value.ToString();
            usuaExistente.Correo = filaActual.Cells["dgCorreoUsuario"].Value.ToString();
            usuaExistente.FechaModificacion = DateTime.Now;
            usuaExistente.Estado = filaActual.Cells["dgEstadoUsuario"].Value.ToString();

            try
            {
                _usuarioService.ActualizarUsuario(usuaExistente);
                _usuarioService.ActualizarCargoEmpleado(usuaExistente, cargoNuevo);
                _usuarioService.ActualizarTipoUsuario(usuaExistente, tipoNuevo);
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
                int FkIdTipoUsuario = (int)fila_actual.Cells["dgFkIdTipoUsuario"].Value;
                int FkIdCargoEmpleado = (int)fila_actual.Cells["dgFkIdCargoEmpleado"].Value;

                try
                {
                    _usuarioService.EliminarUsuario(FkIdTipoUsuario, IdUsuario, FkIdCargoEmpleado);
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

            cmbTipoUsuario.SelectedItem = filaActual.Cells["dgTipoUsuario"].Value.ToString();
            cmbCargoEmpleado.SelectedItem = filaActual.Cells["dgCargoEmpleado"].Value.ToString();
            txtCedulaUsuario.Text = filaActual.Cells["dgCedulaUsuario"].Value.ToString();
            txtNombreUsuario.Text = filaActual.Cells["dgNombreUsuario"].Value.ToString();
            txtTelefonoUsuario.Text = filaActual.Cells["dgTelefonoUsuario"].Value.ToString();
            txtContraseña.Text = filaActual.Cells["dgContraseñaUsuario"].Value.ToString();
            txtCorreoUsuario.Text = filaActual.Cells["dgCorreoUsuario"].Value.ToString();
        }
    }
}
