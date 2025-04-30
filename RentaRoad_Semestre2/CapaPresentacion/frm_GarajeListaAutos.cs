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
using RentaRoad_Semestre3.CapaPresentacion ;
using RentaRoad_Semestre3.CapaNegocio;
using RentaRoad_Semestre3.CapaDatos.Modelos;
using RentaRoad_Semestre3.CapaDatos.Repositorios;
using Microsoft.IdentityModel.Tokens;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_GarajeListaAutos : Form
    {
        private AutoServicio _autoService;
        private ColorServicio _colorService;
        private MarcaServicio _marcaService;
        private ModeloServicio _modeloService;

        public frm_GarajeListaAutos()
        {
            InitializeComponent();
            RentaRoadDbContext context = new RentaRoadDbContext();

            AutoRepositorio repoCa = new AutoRepositorio(context);
            _autoService = new AutoServicio(repoCa);

            ColorRepositorio repoC = new ColorRepositorio(context);
            _colorService = new ColorServicio(repoC);

            MarcaRepositorio repoMa = new MarcaRepositorio(context);
            _marcaService = new MarcaServicio(repoMa);

            ModeloRepositorio repoMo = new ModeloRepositorio(context);
            _modeloService = new ModeloServicio(repoMo);

            actualizarDatagrid();
        }

        private void actualizarDatagrid(List<Auto>? lista = null)
        {
            if (lista.IsNullOrEmpty())
                lista = _autoService.ObtenerTodos();

            dgListaAutos.Rows.Clear();
            foreach (Auto auto in lista)
            {
                string marca = _marcaService.ObtenerPorID(auto.FkMarca).NombreMarca;
                string modelo = _modeloService.ObtenerPorID(auto.FkModelo).NombreModelo;
                string color = _colorService.ObtenerPorID(auto.FkColor).NombreColor;

                dgListaAutos.Rows.Add(
                    auto.PlacaAuto,
                    marca,
                    modelo,
                    color,
                    auto.AñoSalidaAuto,
                    auto.CantidadAsientosAuto,
                    auto.CostoRentaAuto,
                    auto.EstaHabilitado,
                    auto.EstaDisponibleAuto);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofdImagenAuto.ShowDialog();
        }

        private void ControlAutos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            new frm_NuevoModelo().ShowDialog();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            new frm_NuevaMarca().ShowDialog();
        }

        private void btnNuevoColor_Click(object sender, EventArgs e)
        {
            new frm_NuevoColor().ShowDialog();
        }
    }
}
