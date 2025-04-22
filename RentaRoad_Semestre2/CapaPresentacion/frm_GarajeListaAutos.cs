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
using RentaRoad_Semestre3.CapaPresentacion.Subformularios;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_GarajeListaAutos : Form
    {
        public frm_GarajeListaAutos()
        {
            InitializeComponent();
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
