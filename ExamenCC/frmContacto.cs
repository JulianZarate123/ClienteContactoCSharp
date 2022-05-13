using ExamenCC.BL;
using ExamenCC.Entity;
using System;
using System.Windows.Forms;

namespace ExamenCC
{
    public partial class frmContacto : Form
    {
        private Contacto oContactoEdita = new Contacto();
        private int nAccion;
        private int nIdClienteParaNuevo;

        public frmContacto(Contacto oContacto, int nOperacion, int nIdCliente = 0)
        {
            nIdClienteParaNuevo = nIdCliente;
            nAccion = nOperacion;
            InitializeComponent();
            txtClaveContacto.Enabled = false;
            if (nOperacion==2)
            BindeoContacto(oContacto);
            else
                txtClaveContacto.Text = Convert.ToString(oContacto.ClaveContacto);
        }

        public void BindeoContacto(Contacto oClienteContactoBin)
        {
            limpiarCampos();
            oContactoEdita = oClienteContactoBin;
            txtNombreContacto.Text = Convert.ToString(oContactoEdita.NombreContacto);
            txtClaveContacto.Text = Convert.ToString(oContactoEdita.ClaveContacto);
            txtPuestoContacto.Text = Convert.ToString(oContactoEdita.Puesto);
            txttelefonoContacto.Text = Convert.ToString(oContactoEdita.TelefonoContacto);
            txtEmailContacto.Text = Convert.ToString(oContactoEdita.EmailContacto);
        }

        public void AsignaValoresContacto()
        {
            if (nAccion == 1)
            {
                oContactoEdita.IdClienteContacto = nIdClienteParaNuevo;
            }
            oContactoEdita.ClaveContacto = txtClaveContacto.Text; 
            oContactoEdita.NombreContacto = txtNombreContacto.Text;
            oContactoEdita.ClaveContacto = txtClaveContacto.Text;
            oContactoEdita.Puesto = txtPuestoContacto.Text;
            oContactoEdita.TelefonoContacto = txttelefonoContacto.Text;
            oContactoEdita.EmailContacto = txtEmailContacto.Text;
            
        }


        private void btnCancelarCon_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Close();
        }

        public void limpiarCampos()
        {
            txtNombreContacto.Clear();
            txtClaveContacto.Clear();
            txtPuestoContacto.Clear();
            txttelefonoContacto.Clear();
            txtEmailContacto.Clear();
        }

        private void btnGuardarCon_Click(object sender, EventArgs e)
        {

            
            try
            {
                ClienteContactoBL BL = new ClienteContactoBL();
                if (validaCampo())
                {
                    if (nAccion==1)
                    {
                        AsignaValoresContacto();
                        BL.GuardarContacto(oContactoEdita);
                    }
                    else if(nAccion==2)
                    {
                        AsignaValoresContacto();
                        BL.ActualizarContacto(oContactoEdita);
                    }
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error al crear/actualizar el contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public bool validaCampo()
        {
            bool bValida = true;
            try
            {
                if (txtNombreContacto.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDato.SetError(txtNombreContacto, "Debe capturar un nombre de contacto");
                }
                else
                {
                    errorDato.SetError(txtNombreContacto, string.Empty);
                }
                //RFC
                if (txtPuestoContacto.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDato.SetError(txtPuestoContacto, "Debe capturar el puesto del contacto");
                }
                else
                {
                    errorDato.SetError(txtPuestoContacto, string.Empty);
                }
                //CURP
                if (txtEmailContacto.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDato.SetError(txtEmailContacto, "Debe capturar el Email del contacto");
                }
                else
                {
                    errorDato.SetError(txtEmailContacto, string.Empty);
                }

                if (txttelefonoContacto.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDato.SetError(txttelefonoContacto, "Debe capturar el telefono del contacto");
                }
                else
                {
                    errorDato.SetError(txttelefonoContacto, string.Empty);
                }
                

                return bValida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
