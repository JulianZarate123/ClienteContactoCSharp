using ExamenCC.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCC
{
    public partial class frmReporte : Form
    {
        public int idCliente;
        public frmReporte(int IdCliente)
        {
            idCliente = IdCliente;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CrystalReport1 crystalReport1 = new CrystalReport1();
            crystalReport1.SetParameterValue("@nIdCliente01", idCliente);
            crystalReportViewer1.ReportSource = crystalReport1;
            DialogResult = DialogResult.OK;
        }
    }
}
