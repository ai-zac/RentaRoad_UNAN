using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void actualizarDatagrid()
        {
            /* Actualizar la lista de proveedores en el datagrid */
            dgListaProveedores.Rows.Clear();
            List<Proveedor> lista = _proveedorService.ObtenerTodosProveedores();
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

                this.BeginInvoke(new MethodInvoker(actualizarDatagrid));
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
                string? rucProveedor = fila_actual.Cells["dgCodigoRuc"].Value.ToString();

                try
                {
                    _proveedorService.EliminarProveedor(rucProveedor);
                    MessageBox.Show("Proveedor eliminado.");

                    this.BeginInvoke(new MethodInvoker(actualizarDatagrid));
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
    }
}
