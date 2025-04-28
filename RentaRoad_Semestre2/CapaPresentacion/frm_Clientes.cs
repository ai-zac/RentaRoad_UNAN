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
using RentaRoad_Semestre3.CapaPresentacion ;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_Clientes : Form
    {
        private ClienteServicio _clienteService;

        public frm_Clientes()
        {
            InitializeComponent();

            // Configurar el cursor de la BD
            RentaRoadDbContext context = new RentaRoadDbContext();
            ClienteRepositorio repo = new ClienteRepositorio(context);
            _clienteService = new ClienteServicio(repo);

            actualizarDatagrid();
        }

        private void ControlCliente_Load(object sender, EventArgs e)
        { 
        }

        private void actualizarDatagrid(List<Cliente>? lista = null)
        {
            /* Actualizar la lista de clientes en el datagrid */
            if (lista.IsNullOrEmpty())
                lista = _clienteService.ObtenerTodos();

            dgListaClientes.Rows.Clear();
            foreach (Cliente cliente in lista)
            {
                dgListaClientes.Rows.Add(
                    cliente.CedulaCliente,
                    cliente.NombreCliente,
                    cliente.CodigoLicenciaConducir,
                    cliente.TelefonoCliente,
                    cliente.DireccionViviendaCliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /* Evento cuando se guardan datos de un cliente desde los controles */

            Cliente? clienteExistente = _clienteService.ObtenerTodos()
                .FirstOrDefault(c => c.CedulaCliente == txtCedula.Text || c.CodigoLicenciaConducir == txtLicencia.Text);

            // Si el cliente ya existe, solo actualiza los datos
            if (clienteExistente != null)
            {
                if (clienteExistente.CodigoLicenciaConducir != txtLicencia.Text)
                {
                    MessageBox.Show("No se puede asignar otra licencia de conducir al cliente");
                    return;
                }

                if (clienteExistente.CedulaCliente != txtCedula.Text)
                {
                    MessageBox.Show("No se puede asignar otra cedula al cliente");
                    return;
                }

                clienteExistente.NombreCliente = txtNombre.Text;
                clienteExistente.TelefonoCliente = txtTelefono.Text;
                clienteExistente.CodigoLicenciaConducir = txtLicencia.Text;
                clienteExistente.CedulaCliente = txtCedula.Text;
                clienteExistente.DireccionViviendaCliente = txtDireccion.Text;
                clienteExistente.FechaModificacion = DateTime.Now;

                _clienteService.ActualizarCliente(clienteExistente);
                MessageBox.Show("Se actualizo correctamente el cliente");
                actualizarDatagrid();
                return;
            }

            // Sino existe el cliente, se crea uno nuevo
            try
            {
                Cliente clien = new Cliente
                {
                    NombreCliente = txtNombre.Text,
                    CedulaCliente = txtCedula.Text,
                    TelefonoCliente = txtTelefono.Text,
                    CodigoLicenciaConducir = txtLicencia.Text,
                    DireccionViviendaCliente = txtDireccion.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                };

                _clienteService.CrearCliente(clien);
                MessageBox.Show("Cliente agregado.");

                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgListaClientes_actualizarCliente(object sender, DataGridViewCellEventArgs e)
        {
            /* Editando los datos de un cliente directamente desde el datagrid en modo edicion */

            DataGridViewRow filaActual = dgListaClientes.Rows[e.RowIndex];

            string cedulaClienSelec = filaActual.Cells["clmCedula"].Value.ToString();
            Cliente? clienteSelec = _clienteService.ObtenerTodos()
                                    .FirstOrDefault(c => c.TelefonoCliente == cedulaClienSelec);
            if (clienteSelec == null)
            {
                MessageBox.Show("El cliente no existe en la base de datos");
                return;
            }

            clienteSelec.NombreCliente = filaActual.Cells["clmNombre"].Value.ToString();
            clienteSelec.TelefonoCliente = filaActual.Cells["clmTelefono"].Value.ToString();
            clienteSelec.CodigoLicenciaConducir = filaActual.Cells["clmLicencia"].Value.ToString();
            clienteSelec.CedulaCliente = filaActual.Cells["clmCedula"].Value.ToString();
            clienteSelec.DireccionViviendaCliente = filaActual.Cells["clmDireccion"].Value.ToString();
            clienteSelec.FechaModificacion = DateTime.Now;

            try
            {
                _clienteService.ActualizarCliente(clienteSelec);
                MessageBox.Show("Cliente actualizado.");

                actualizarDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgListaClientes_eliminarClientes(object sender, DataGridViewCellEventArgs e)
        {
            /* Eliminar un cliente dando click a la ultima celda de la fila */

            // La ultima columna es para la funcionalidad de eliminar el cliente de x fila
            if (e.ColumnIndex == dgListaClientes.ColumnCount - 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de eliminar?", "Confirmar",
                                 MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.No)
                    return;

                DataGridViewRow fila_actual = dgListaClientes.Rows[e.RowIndex];
                try
                {
                    string cedulaCliente = fila_actual.Cells["clmCedula"].Value.ToString();
                    _clienteService.EliminarCliente(cedulaCliente);
                    MessageBox.Show("Cliente eliminado.");

                    actualizarDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgListaClientes_seleccionarCliente(object sender, DataGridViewCellEventArgs e)
        {
            /* Poblar los controles con los datos de la fila que se le dio click en el datagrid */

            DataGridViewRow filaActual = dgListaClientes.Rows[e.RowIndex];

            txtCedula.Text = filaActual.Cells["clmCedula"].Value.ToString();
            txtNombre.Text = filaActual.Cells["clmNombre"].Value.ToString();
            txtTelefono.Text = filaActual.Cells["clmTelefono"].Value.ToString();
            txtDireccion.Text = filaActual.Cells["clmDireccion"].Value.ToString();
            txtLicencia.Text = filaActual.Cells["clmLicencia"].Value.ToString();
        }

        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            string cedulaInser = txtCedula.Text;
            List<Cliente>? coincidenciaClientes = _clienteService.ObtenerTodos().Where(c => c.CedulaCliente.Contains(cedulaInser)).ToList();
            mostrarCoincidenciasClientes(coincidenciaClientes);
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombreInser = txtNombre.Text;
            List<Cliente>? coincidenciaClientes = _clienteService.ObtenerTodos().Where(c => c.NombreCliente.Contains(nombreInser)).ToList();
            mostrarCoincidenciasClientes(coincidenciaClientes);
        }

        private void btnBuscarTelefono_Click(object sender, EventArgs e)
        {
            string telefonoInser = txtTelefono.Text;
            List<Cliente>? coincidenciaClientes = _clienteService.ObtenerTodos().Where(c => c.TelefonoCliente.Contains(telefonoInser)).ToList();
            mostrarCoincidenciasClientes(coincidenciaClientes);
        }

        private void btnBuscarLicencia_Click(object sender, EventArgs e)
        {
            string licenciaInser = txtLicencia.Text;
            List<Cliente>? coincidenciaClientes = _clienteService.ObtenerTodos().Where(c => c.CodigoLicenciaConducir.Contains(licenciaInser)).ToList();
            mostrarCoincidenciasClientes(coincidenciaClientes);
        }

        private void mostrarCoincidenciasClientes(List<Cliente> coincidencias)
        {
            if (coincidencias.IsNullOrEmpty())
            {
                MessageBox.Show("No se encontro coincidencias");
                actualizarDatagrid();
                return;
            }

            if (coincidencias.Count == 1)
            {
                Cliente? cliente = coincidencias.First();

                txtCedula.Text = cliente.CedulaCliente.ToString();
                txtNombre.Text = cliente.NombreCliente.ToString();
                txtTelefono.Text = cliente.TelefonoCliente.ToString();
                txtDireccion.Text = cliente.DireccionViviendaCliente.ToString();
                txtLicencia.Text = cliente.CodigoLicenciaConducir.ToString();
            }

            actualizarDatagrid(coincidencias);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            actualizarDatagrid();
        }
    }
}
