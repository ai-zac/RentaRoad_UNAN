using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaRoad_Semestre3.CapaPresentacion.Subformularios;

namespace RentaRoad_Semestre3.CapaPresentacion
{
    public partial class frm_GarajeEntregaAutoRentado : Form
    {
        public frm_GarajeEntregaAutoRentado()
        {
            InitializeComponent();
        }

        private void btnBuscarContrato_Click(object sender, EventArgs e)
        {
            new frm_SeleccionContrato_PorPlaca().ShowDialog();
        }
    }
}
