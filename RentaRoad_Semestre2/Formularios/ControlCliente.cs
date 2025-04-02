using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaRoad_Semestre3.Formularios.Subformularios;

namespace RentaRoad_Semestre3.Formularios
{
    public partial class ControlCliente : Form
    {
        public ControlCliente()
        {
            InitializeComponent();
        }

        private void ControlCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeleccionClientes().ShowDialog();
        }
    }
}
