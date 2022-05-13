using ExamenCC.BL;
using ExamenCC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamenCC
{
    public partial class frmSeleccionaCliente : Form
    {
        public frmSeleccionaCliente()
        {
            InitializeComponent();
            ListaGeneralClientes();
        }

        #region Variables
        public int IdCliente;
        private List<ClienteContacto> listClientes;
        public ClienteContacto oCliente = new ClienteContacto();
        #endregion Variables

        public void ListaGeneralClientes()
        {

            ClienteContactoBL BL = new ClienteContactoBL();

            try
            {

                listClientes = BL.ListaClienteGeneral();

                if (listClientes.Any())
                {
                    dgvCliente.DataSource = listClientes;
                    configuracionGrid();
                }
                else
                {
                    MessageBox.Show("No se encontro registro", "Concepto Referencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void configuracionGrid()
        {
            dgvCliente.Columns["nIdCliente01"].Visible = false;
            dgvCliente.Columns["sClave"].Visible = true;
            dgvCliente.Columns["sNombre"].Visible = true;
            dgvCliente.Columns["sApellidoPat"].Visible = true;
            dgvCliente.Columns["sApellidoMat"].Visible = true;
            dgvCliente.Columns["sRazonSocial"].Visible = true;
            dgvCliente.Columns["bTipoPersona"].Visible = false;
            dgvCliente.Columns["sNombreComercial"].Visible = true;
            dgvCliente.Columns["sCalle"].Visible = true;
            dgvCliente.Columns["nCodigoPostal"].Visible = true;
            dgvCliente.Columns["nExterior"].Visible = true;
            dgvCliente.Columns["sColonia"].Visible = false;
            dgvCliente.Columns["sMunicipio"].Visible = false;
            dgvCliente.Columns["sEstado"].Visible = false;
            dgvCliente.Columns["sPais"].Visible = false;
            dgvCliente.Columns["sRFC"].Visible = false;
            dgvCliente.Columns["sCURP"].Visible = false;
            dgvCliente.Columns["nNumeroTelefono"].Visible = false;
            dgvCliente.Columns["sEmail"].Visible = false;
            dgvCliente.Columns["bEstatus"].Visible = false;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorCelda;
            if (e.RowIndex < 0)
                return;
            else
                valorCelda = dgvCliente.Rows[e.RowIndex].Cells["nIdCliente01"].Value.ToString();

            if (dgvCliente.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvCliente.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCliente.Rows[selectedrowindex];
                oCliente.nIdCliente01 = Convert.ToInt32(valorCelda);
                oCliente.sClave = selectedRow.Cells["sClave"].Value.ToString();
                oCliente.sNombre = selectedRow.Cells["sNombre"].Value.ToString();
                oCliente.sApellidoPat = selectedRow.Cells["sApellidoPat"].Value.ToString();
                oCliente.sApellidoMat = selectedRow.Cells["sApellidoMat"].Value.ToString();
                oCliente.sRazonSocial = selectedRow.Cells["sRazonSocial"].Value.ToString();
                oCliente.bTipoPersona = Convert.ToInt32(selectedRow.Cells["bTipoPersona"].Value.ToString());
                oCliente.sNombreComercial = selectedRow.Cells["sNombreComercial"].Value.ToString();
                oCliente.sCalle = selectedRow.Cells["sCalle"].Value.ToString();
                oCliente.nCodigoPostal = selectedRow.Cells["nCodigoPostal"].Value.ToString();
                oCliente.nExterior = selectedRow.Cells["nExterior"].Value.ToString();
                oCliente.sColonia = selectedRow.Cells["sColonia"].Value.ToString();
                oCliente.sMunicipio = selectedRow.Cells["sMunicipio"].Value.ToString();
                oCliente.sEstado = selectedRow.Cells["sEstado"].Value.ToString();
                oCliente.sPais = selectedRow.Cells["sPais"].Value.ToString();
                oCliente.sRFC = selectedRow.Cells["sRFC"].Value.ToString();
                oCliente.sCURP = selectedRow.Cells["sCURP"].Value.ToString();
                oCliente.nNumeroTelefono = selectedRow.Cells["nNumeroTelefono"].Value.ToString();
                oCliente.sEmail = selectedRow.Cells["sEmail"].Value.ToString();
                oCliente.bEstatus = Convert.ToInt32(selectedRow.Cells["bEstatus"].Value.ToString());

                DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
