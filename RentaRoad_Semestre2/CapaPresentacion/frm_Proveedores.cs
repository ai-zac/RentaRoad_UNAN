using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using RentaRoad_Semestre3.CapaNegocio;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_Proveedores : Form
    {
        private ProveedorServicio _proveedorService;

        public frm_Proveedores()
        {
            InitializeComponent();

            // Configurar el cursor de la BD
            RentaRoadDbContext context = new RentaRoadDbContext();
            ProveedorRepositorio repo = new ProveedorRepositorio(context);
            _proveedorService = new ProveedorServicio(repo);

            actualizarDatagrid();
        }

        private void actualizarDatagrid(List<Proveedor>? lista = null)
        {
            /* Actualizar la lista de proveedores en el datagrid */
            if (lista.IsNullOrEmpty())
                lista = _proveedorService.ObtenerTodosProveedores();

            dgListaProveedores.Rows.Clear();
            foreach (Proveedor proveedor in lista)
            {
                dgListaProveedores.Rows.Add(
                    proveedor.RucProveedor,
                    proveedor.NombreProveedor,
                    proveedor.TelefonoProveedor,
                    proveedor.CorreoProveedor,
                    proveedor.EstaHabilitado
                    );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /* Evento cuando se guardan datos de un cliente desde los controles */

            Proveedor? proveedorExistente = _proveedorService.ObtenerTodosProveedores()
                .FirstOrDefault(p => p.RucProveedor == txtRUC.Text);

            // Si el cliente ya existe, solo actualiza los datos
            if (proveedorExistente != null)
            {
                if (proveedorExistente.RucProveedor != txtRUC.Text)
                {
                    MessageBox.Show("No se puede asignar otra código RUC al proveedor");
                    return;
                }

                proveedorExistente.NombreProveedor = txtNombre.Text;
                proveedorExistente.TelefonoProveedor = txtTelefono.Text;
                proveedorExistente.CorreoProveedor = txtCorreo.Text;
                proveedorExistente.FechaModificacion = DateTime.Now;
                proveedorExistente.EstaHabilitado = chbEstaHabilitado.Checked;

                _proveedorService.ActualizarProveedor(proveedorExistente);
                MessageBox.Show("Se actualizo correctamente el proveedor");
                actualizarDatagrid();
                return;
            }

            try
            {
                Proveedor provee = new Proveedor
                {
                    RucProveedor = txtRUC.Text,
                    NombreProveedor = txtNombre.Text,
                    TelefonoProveedor = txtTelefono.Text,
                    CorreoProveedor = txtCorreo.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                    EstaHabilitado = chbEstaHabilitado.Checked,
                };

                _proveedorService.CrearProveedor(provee);
                MessageBox.Show("Proveedor agregado.");

                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgListaProveedores_actualizarProveedor(object sender, DataGridViewCellEventArgs e)
        {
            /* Editando los datos de un proveedor directamente desde el datagrid en modo edicion */

            DataGridViewRow filaActual = dgListaProveedores.Rows[e.RowIndex];

            string? rucProveedorActual = filaActual.Cells["dgCodigoRuc"].Value.ToString();
            Proveedor? proveeExistente = _proveedorService.ObtenerTodosProveedores()
                                    .FirstOrDefault(p => p.RucProveedor == rucProveedorActual);
            if (proveeExistente == null)
            {
                MessageBox.Show("El proveedor no existe en la base de datos");
                return;
            }

            proveeExistente.RucProveedor = filaActual.Cells["dgCodigoRuc"].Value.ToString();
            proveeExistente.NombreProveedor = filaActual.Cells["dgNombre"].Value.ToString();
            proveeExistente.TelefonoProveedor = filaActual.Cells["dgTelefono"].Value.ToString();
            proveeExistente.CorreoProveedor = filaActual.Cells["dgCorreo"].Value.ToString();
            proveeExistente.FechaModificacion = DateTime.Now;
            proveeExistente.EstaHabilitado = bool.Parse(filaActual.Cells["dgEstado"].Value.ToString());

            try
            {
                _proveedorService.ActualizarProveedor(proveeExistente);
                MessageBox.Show("Proveedor actualizado.");

                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void dgListaProveedores_eliminarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            /* Eliminar un proveedor dando click a la ultima celda de la fila */

            // La ultima columna es para la funcionalidad de eliminar el proveedor de x fila
            if (e.ColumnIndex == dgListaProveedores.ColumnCount - 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de eliminar?", "Confirmar",
                                 MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.No)
                    return;

                DataGridViewRow fila_actual = dgListaProveedores.Rows[e.RowIndex];

                try
                {
                    string rucProveedor = fila_actual.Cells["dgCodigoRuc"].Value.ToString();
                    _proveedorService.EliminarProveedor(rucProveedor);
                    MessageBox.Show("Proveedor eliminado.");

                    actualizarDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgListaProveedores_seleccionarProveedor(object sender, DataGridViewCellEventArgs e)
        {
            /* Poblar los controles con los datos de la fila que se le dio click en el datagrid */

            DataGridViewRow filaActual = dgListaProveedores.Rows[e.RowIndex];

            string rucProveedorSelec = filaActual.Cells["dgCodigoRuc"].Value.ToString();
            Proveedor? proveedorSelec = _proveedorService.ObtenerTodosProveedores()
                                    .FirstOrDefault(p => p.RucProveedor == rucProveedorSelec);

            txtRUC.Text = filaActual.Cells["dgCodigoRuc"].Value.ToString();
            txtNombre.Text = filaActual.Cells["dgNombre"].Value.ToString();
            txtTelefono.Text = filaActual.Cells["dgTelefono"].Value.ToString();
            txtCorreo.Text = filaActual.Cells["dgCorreo"].Value.ToString();
            chbEstaHabilitado.Checked = bool.Parse(filaActual.Cells["dgEstado"].Value.ToString());
        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarRUC_Click(object sender, EventArgs e)
        {
            string rucInser = txtRUC.Text;
            List<Proveedor>? coincidenciaProveedores = _proveedorService.ObtenerTodosProveedores().Where(c => c.RucProveedor.Contains(rucInser)).ToList();
            mostrarCoincidenciasProveedores(coincidenciaProveedores);
        }

        private void mostrarCoincidenciasProveedores(List<Proveedor> coincidencias)
        {
            if (coincidencias.IsNullOrEmpty())
            {
                MessageBox.Show("No se encontro coincidencias");
                actualizarDatagrid();
                return;
            }

            if (coincidencias.Count == 1)
            {
                Proveedor? proveedor = coincidencias.First();

                txtRUC.Text = proveedor.RucProveedor;
                txtNombre.Text = proveedor.NombreProveedor;
                txtCorreo.Text = proveedor.CorreoProveedor;
                txtTelefono.Text = proveedor.TelefonoProveedor;
            }

            actualizarDatagrid(coincidencias);
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            string correoInser = txtCorreo.Text;
            List<Proveedor>? coincidenciaProveedores = _proveedorService.ObtenerTodosProveedores().Where(c => c.CorreoProveedor.Contains(correoInser)).ToList();
            mostrarCoincidenciasProveedores(coincidenciaProveedores);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            string nombreInser = txtNombre.Text;
            List<Proveedor>? coincidenciaProveedores = _proveedorService.ObtenerTodosProveedores().Where(c => c.NombreProveedor.Contains(nombreInser)).ToList();
            mostrarCoincidenciasProveedores(coincidenciaProveedores);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            string telefonoInser = txtTelefono.Text;
            List<Proveedor>? coincidenciaProveedores = _proveedorService.ObtenerTodosProveedores().Where(c => c.TelefonoProveedor.Contains(telefonoInser)).ToList();
            mostrarCoincidenciasProveedores(coincidenciaProveedores);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            actualizarDatagrid();
        }
    }
}
