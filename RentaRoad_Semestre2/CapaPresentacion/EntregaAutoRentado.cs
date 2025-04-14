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
    public partial class EntregaAutoRentado : Form
    {
        public EntregaAutoRentado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            new SeleccionContrato().ShowDialog();
        }
    }
}
