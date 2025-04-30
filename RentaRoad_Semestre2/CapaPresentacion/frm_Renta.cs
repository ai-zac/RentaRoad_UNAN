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

    public partial class frm_Renta : Form
    {
        private Usuario usuarioEncargado;

        private UsuariosService _usuarioService;
        private AutoServicio _autoService;
        private ClienteServicio _clienteService;
        private ContratoServicio _contratoService;
        private ColorServicio _colorService;
        private MarcaServicio _marcaService;
        private ModeloServicio _modeloService;

        public frm_Renta(Usuario usuarioIngresado)
        {
            InitializeComponent();

            RentaRoadDbContext context = new RentaRoadDbContext();

            UsuarioRepositorio repoU = new UsuarioRepositorio(context);
            _usuarioService = new UsuariosService(repoU);

            AutoRepositorio repoCa = new AutoRepositorio(context);
            _autoService = new AutoServicio(repoCa);

            ClienteRepositorio repoCl = new ClienteRepositorio(context);
            _clienteService = new ClienteServicio(repoCl);

            ContratoRepositorio repoCr = new ContratoRepositorio(context);
            _contratoService = new ContratoServicio(repoCr);

            ColorRepositorio repoC = new ColorRepositorio(context);
            _colorService = new ColorServicio(repoC);

            MarcaRepositorio repoMa = new MarcaRepositorio(context);
            _marcaService = new MarcaServicio(repoMa);

            ModeloRepositorio repoMo = new ModeloRepositorio(context);
            _modeloService = new ModeloServicio(repoMo);


            usuarioEncargado = usuarioIngresado;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            new frm_PagoTarjetaCredito().ShowDialog();
        }

        private void frm_Renta_Load(object sender, EventArgs e)
        {
            cmbPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection customSourceCmbPlaca = new AutoCompleteStringCollection();
            List<Auto> autosDB = _autoService.ObtenerTodos();
            foreach (Auto autoDB in autosDB)
            {
                customSourceCmbPlaca.Add(autoDB.PlacaAuto);
                cmbPlaca.Items.Add(autoDB.PlacaAuto);
            }
            cmbPlaca.AutoCompleteCustomSource = customSourceCmbPlaca;

            cmbTelefonoCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTelefonoCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection customSourceCmbTelefono = new AutoCompleteStringCollection();
            List<Cliente> clientesDB = _clienteService.ObtenerTodos();
            foreach (Cliente clienteDB in clientesDB)
            {
                customSourceCmbTelefono.Add(clienteDB.TelefonoCliente);
                cmbTelefonoCliente.Items.Add(clienteDB.TelefonoCliente);
            }
            cmbTelefonoCliente.AutoCompleteCustomSource = customSourceCmbTelefono;

            txtSeguros.Text = "50000.00";
        }

        private void cmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placaSelec = cmbPlaca.SelectedItem.ToString();
            Auto? autoSelec = _autoService.ObtenerPorPlaca(placaSelec);

            if (autoSelec == null)
            {
                MessageBox.Show("El auto no existe en la base de datos");
                return;
            }

            txtMarca.Text = _marcaService.ObtenerPorID(autoSelec.FkMarca).NombreMarca;
            txtmodelo.Text = _modeloService.ObtenerPorID(autoSelec.FkModelo).NombreModelo;
            txtcolor.Text = _colorService.ObtenerPorID(autoSelec.FkColor).NombreColor;
            txtAño.Text = autoSelec.AñoSalidaAuto.ToString();
            txtprecio.Text = autoSelec.CostoRentaAuto.ToString();
            txtasientos.Text = autoSelec.CantidadAsientosAuto.ToString();

            calculoContrato();
        }

        private void cmbTelefonoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string telefonoSelec = cmbTelefonoCliente.SelectedItem.ToString();
            Cliente? clienteSelec = _clienteService.ObtenerTodos().FirstOrDefault(c => c.TelefonoCliente == telefonoSelec);

            if (clienteSelec == null)
            {
                MessageBox.Show("El cliente no existe en la base de datos");
                return;
            }

            txtnombrecliente.Text = clienteSelec.NombreCliente.ToString();
            txtcedula.Text = clienteSelec.CedulaCliente.ToString();
            txtlicencia.Text = clienteSelec.CodigoLicenciaConducir.ToString();
            txtdireccion.Text = clienteSelec.DireccionViviendaCliente.ToString();
        }

        private void dtpHastaPlazo_ValueChanged(object sender, EventArgs e)
        {
            DateTime desde = dtpDesdePlazo.Value;
            DateTime hasta = dtpHastaPlazo.Value;
            TimeSpan tsDiff = hasta - desde;
            int dias = Math.Abs(tsDiff.Days + 1);
            txtCantidadDias.Text = dias.ToString(); 

            calculoContrato();
        }

        private void dtpDesdePlazo_ValueChanged(object sender, EventArgs e)
        {
            DateTime desde = dtpDesdePlazo.Value;
            DateTime hasta = dtpHastaPlazo.Value;
            TimeSpan tsDiff = desde - hasta;
            int dias = Math.Abs(tsDiff.Days + 1);
            txtCantidadDias.Text = dias.ToString(); 

            calculoContrato();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtnombrecliente.Enabled = true;
            txtnombrecliente.ReadOnly = false;
 
            txtcedula.Enabled = true;
            txtcedula.ReadOnly = false;

            txtlicencia.Enabled = true;
            txtlicencia.ReadOnly = false;

            txtdireccion.Enabled = true;
            txtdireccion.ReadOnly = false;

            btnGuardarCliente.Visible = true;
        }

        private void btnNuevoContrato_Click(object sender, EventArgs e)
        {

            MessageBox.Show(usuarioEncargado.NombreUsuario.ToString());
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).Text = "";
                    else
                        func(control.Controls);
            };

            func(this.Controls);

            txtCantidadDias.Text = "0";
            txtDescuentos.Text = "0.0";
            txtTotal.Text = "0.0";
            txtGarantia.Text = "0.0";
            txtDescuentos.Text = "0.0";
            txtCambio.Text = "0.0";
        }

        private void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            Cliente? cliente = _clienteService.ObtenerTodos().FirstOrDefault(c => c.TelefonoCliente == cmbTelefonoCliente.Text);
            if (cliente  == null)
            {
                MessageBox.Show("Cliente no existe");
                return;
            }
            
            Auto? auto = _autoService.ObtenerTodos().FirstOrDefault(c => c.PlacaAuto == cmbPlaca.Text);
            if (auto  == null)
            {
                MessageBox.Show("Auto no existe");
                return;
            }

            if (usuarioEncargado == null)
            {
                MessageBox.Show("Usuario no reconocido");
                return;
            }

            Contrato contrato = new Contrato
            {
                FkCedulaClienteNavigation = cliente,
                FkAutoNavigation = auto,
                IdUsuarioNavigation = usuarioEncargado,
                FechaCreacionContrato = DateTime.Now,
                TipoPagoContrato = "tarjeta",
                MontoTotalContrato = decimal.Parse(txtTotal.Text),
                CantidadDiasRentaContrato = int.Parse(txtCantidadDias.Text),
                MontoGarantiaContrato = decimal.Parse(txtGarantia.Text),
                PorcentajeDescuentoContrato = decimal.Parse(txtDescuentos.Text),
                EstaFinalizadoContrato = false,
            };

            // _contratoService.CrearContrato(contrato);
        }

        private void txtPagoCordobas_TextChanged(object sender, EventArgs e)
        {
            calculoCambio();
        }

        private void txtPagoDolares_TextChanged(object sender, EventArgs e)
        {
            calculoCambio();
        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            calculoContrato();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente? clienteExis = _clienteService.ObtenerTodos().FirstOrDefault(c => c.TelefonoCliente == cmbTelefonoCliente.Text);
            if (clienteExis != null)
            {
                MessageBox.Show("Ya existe un cliente con el número de teléfono ingresado");
                return;
            }

            try
            {
                Cliente clien = new Cliente
                {
                    NombreCliente = txtnombrecliente.Text,
                    CedulaCliente = txtcedula.Text,
                    TelefonoCliente = cmbTelefonoCliente.Text,
                    CodigoLicenciaConducir = txtlicencia.Text,
                    DireccionViviendaCliente = txtdireccion.Text,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                };

                _clienteService.CrearCliente(clien);
                MessageBox.Show("Cliente agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            txtnombrecliente.Enabled = false;
            txtcedula.Enabled = false;
            txtlicencia.Enabled = false;
            txtdireccion.Enabled = false;

            btnGuardarCliente.Visible = false;
        }

        private void calculoContrato()
        {
            if (!txtCantidadDias.Text.IsNullOrEmpty() &&
                !txtprecio.Text.IsNullOrEmpty() &&
                !txtDescuentos.Text.IsNullOrEmpty() &&
                !txtDescuentos.Text.All(Char.IsDigit) &&
                txtCantidadDias.Text.All(Char.IsDigit))
            {
                txtSubTotal.Text = (decimal.Parse(txtCantidadDias.Text) * decimal.Parse(txtprecio.Text)).ToString();
                txtGarantia.Text = (decimal.Parse(txtSubTotal.Text) * (decimal)0.1).ToString();
                txtTotal.Text = ((decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtGarantia.Text)) - (decimal.Parse(txtSubTotal.Text) * (decimal.Parse(txtDescuentos.Text) / 100))).ToString();
            }
        }

        private void calculoCambio()
        {
            if (!txtTotal.Text.IsNullOrEmpty())
            {
                txtCambio.Text = (decimal.Parse(txtTotal.Text) - (decimal.Parse(txtPagoCordobas.Text) + (decimal.Parse(txtPagoDolares.Text) * (decimal)35.6))).ToString();
            }
        }
    }
}
