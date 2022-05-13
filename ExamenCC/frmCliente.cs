using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenCC.BL;
using ExamenCC.Entity;

namespace ExamenCC
{
    public partial class frmCliente : Form
    {
    #region Variables
        private enum Estatus
        {
            Ninguno = 0,
            Lectura = 1,
            Edicion = 2,
            Eliminacion = 3,
            Nuevo = 4
        }
        private Estatus eEstatus;
        private List<Contacto> listContactos;
        private ClienteContacto oClienteContacto;
        private ClienteContacto oCliente = new ClienteContacto();
        private Contacto oContacto = new Contacto();
        private int idContactoelimina;
        private string sClaveContacto;
        #endregion Variables


        public frmCliente()
        {
            InitializeComponent();
            eEstatus = Estatus.Ninguno;
            cmbTipoPersona.Text = "MORAL";
            cmbTipoPersona.SelectedValue = "MORAL";
            cmbTipoPersona.SelectedItem = "MORAL";
            HabilitarControles();
            //ListaGeneral();
            oClienteContacto = new ClienteContacto();
        }

        #region Metodos
        public void HabilitarControles()
        {
            try
            {
                switch (eEstatus)
                {
                    case Estatus.Ninguno:
                        #region Ninguno
                        btnNuevo.Enabled = true;
                        btnEditar.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnBuscar.Enabled = true;
                        txtClaveCliente.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnEliminaContacto.Enabled = false;
                        btnReporte.Enabled = false;
                        txtClaveCliente.Enabled = false;
                        if (cmbTipoPersona.SelectedIndex.Equals(1))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = false;
                            lblNombre.Enabled = false;
                            txtApellidoPat.Enabled = false;
                            lblApellidoPat.Enabled = false;
                            txtApellidoMat.Enabled = false;
                            lblApellidoMat.Enabled = false;
                            txtNombreCliente.Visible = false;
                            lblNombre.Visible = false;
                            txtApellidoPat.Visible = false;
                            lblApellidoPat.Visible = false;
                            txtApellidoMat.Visible = false;
                            lblApellidoMat.Visible = false;
                            txtRazonSocial.Enabled = true;
                            lblRazonSocial.Enabled = true;
                            txtRazonSocial.Visible = true;
                            lblRazonSocial.Visible = true;
                            #endregion PersonaMoral

                        }
                        else if (cmbTipoPersona.SelectedIndex.Equals(0))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = false;
                            lblNombre.Enabled = true;
                            txtApellidoPat.Enabled = false;
                            lblApellidoPat.Enabled = true;
                            txtApellidoMat.Enabled = false;
                            lblApellidoMat.Enabled = true;
                            txtNombreCliente.Visible = true;
                            lblNombre.Visible = true;
                            txtApellidoPat.Visible = true;
                            lblApellidoPat.Visible = true;
                            txtApellidoMat.Visible = true;
                            lblApellidoMat.Visible = true;
                            txtRazonSocial.Enabled = false;
                            lblRazonSocial.Enabled = false;
                            txtRazonSocial.Visible = false;
                            lblRazonSocial.Visible = false;
                            #endregion PersonaMoral
                        }
                        #region camposTXT
                        txtRazonSocial.Enabled = false;
                        cmbTipoPersona.Enabled = false;
                        chkStatus.Enabled = false;
                        txtNombreComercial.Enabled = false;
                        txtCURP.Enabled = false;
                        txtRFC.Enabled = false;
                        txtxNumeroTelefono.Enabled = false;
                        txtEmail.Enabled = false;
                        txtCalle.Enabled = false;
                        txtNumExterior.Enabled = false;
                        txtColonia.Enabled = false;
                        txtCP.Enabled = false;
                        txtEstado.Enabled = false;
                        txtMunicipio.Enabled = false;
                        txtPais.Enabled = false;
                        #endregion camposTXT
                        #endregion Ninguno
                        break;
                    case Estatus.Lectura:
                        #region Lectura
                        btnNuevo.Enabled = true;
                        btnEditar.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnEliminar.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnBuscar.Enabled = true;
                        txtClaveCliente.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnEliminaContacto.Enabled = false;
                        btnReporte.Enabled = true;
                        txtClaveCliente.Enabled = false;
                        if (cmbTipoPersona.SelectedIndex.Equals(1))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = false;
                            lblNombre.Enabled = false;
                            txtApellidoPat.Enabled = false;
                            lblApellidoPat.Enabled = false;
                            txtApellidoMat.Enabled = false;
                            lblApellidoMat.Enabled = false;
                            txtNombreCliente.Visible = false;
                            lblNombre.Visible = false;
                            txtApellidoPat.Visible = false;
                            lblApellidoPat.Visible = false;
                            txtApellidoMat.Visible = false;
                            lblApellidoMat.Visible = false;
                            txtRazonSocial.Enabled = true;
                            lblRazonSocial.Enabled = true;
                            txtRazonSocial.Visible = true;
                            lblRazonSocial.Visible = true;
                            #endregion PersonaMoral

                        }
                        else if (cmbTipoPersona.SelectedIndex.Equals(0))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = false;
                            lblNombre.Enabled = true;
                            txtApellidoPat.Enabled = false;
                            lblApellidoPat.Enabled = true;
                            txtApellidoMat.Enabled = false;
                            lblApellidoMat.Enabled = true;
                            txtNombreCliente.Visible = true;
                            lblNombre.Visible = true;
                            txtApellidoPat.Visible = true;
                            lblApellidoPat.Visible = true;
                            txtApellidoMat.Visible = true;
                            lblApellidoMat.Visible = true;
                            txtRazonSocial.Enabled = false;
                            lblRazonSocial.Enabled = false;
                            txtRazonSocial.Visible = false;
                            lblRazonSocial.Visible = false;
                            #endregion PersonaMoral
                        }
                        #region camposTXT
                        txtRazonSocial.Enabled = false;
                        cmbTipoPersona.Enabled = false;
                        chkStatus.Enabled = false;
                        txtNombreComercial.Enabled = false;
                        txtCURP.Enabled = false;
                        txtRFC.Enabled = false;
                        txtxNumeroTelefono.Enabled = false;
                        txtEmail.Enabled = false;
                        txtCalle.Enabled = false;
                        txtNumExterior.Enabled = false;
                        txtColonia.Enabled = false;
                        txtCP.Enabled = false;
                        txtEstado.Enabled = false;
                        txtMunicipio.Enabled = false;
                        txtPais.Enabled = false;
                        #endregion camposTXT

                        #endregion Lectura
                        break;
                    case Estatus.Edicion:
                    case Estatus.Nuevo:
                        #region Edicion/Nuevo
                        btnNuevo.Enabled = false;
                        btnEditar.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnEliminar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnBuscar.Enabled = false;
                        txtClaveCliente.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnEliminaContacto.Enabled = true;
                        btnReporte.Enabled = false;
                        txtClaveCliente.Enabled = false;
                        if (cmbTipoPersona.SelectedIndex.Equals(1))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = false;
                            lblNombre.Enabled = false;
                            txtApellidoPat.Enabled = false;
                            lblApellidoPat.Enabled = false;
                            txtApellidoMat.Enabled = false;
                            lblApellidoMat.Enabled = false;
                            txtNombreCliente.Visible = false;
                            lblNombre.Visible = false;
                            txtApellidoPat.Visible = false;
                            lblApellidoPat.Visible = false;
                            txtApellidoMat.Visible = false;
                            lblApellidoMat.Visible = false;
                            txtRazonSocial.Enabled = true;
                            lblRazonSocial.Enabled = true;
                            txtRazonSocial.Visible = true;
                            lblRazonSocial.Visible = true;
                            #endregion PersonaMoral

                        }
                        else if (cmbTipoPersona.SelectedIndex.Equals(0))
                        {
                            #region PersonaMoral
                            txtNombreCliente.Enabled = true;
                            lblNombre.Enabled = true;
                            txtApellidoPat.Enabled = true;
                            lblApellidoPat.Enabled = true;
                            txtApellidoMat.Enabled = true;
                            lblApellidoMat.Enabled = true;
                            txtNombreCliente.Visible = true;
                            lblNombre.Visible = true;
                            txtApellidoPat.Visible = true;
                            lblApellidoPat.Visible = true;
                            txtApellidoMat.Visible = true;
                            lblApellidoMat.Visible = true;
                            txtRazonSocial.Enabled = false;
                            lblRazonSocial.Enabled = false;
                            txtRazonSocial.Visible = false;
                            lblRazonSocial.Visible = false;
                            #endregion PersonaMoral
                        }
                        cmbTipoPersona.Enabled = true;
                        chkStatus.Enabled = true;
                        txtNombreComercial.Enabled = true;
                        txtCURP.Enabled = true;
                        txtRFC.Enabled = true;
                        txtxNumeroTelefono.Enabled = true;
                        txtEmail.Enabled = true;
                        txtCalle.Enabled = true;
                        txtNumExterior.Enabled = true;
                        txtColonia.Enabled = true;
                        txtCP.Enabled = true;
                        txtEstado.Enabled = true;
                        txtMunicipio.Enabled = true;
                        txtPais.Enabled = true;
                        #endregion Edicion/Nuevo
                        break;
                }
            }
            catch
            {

            }

        }

        public void limpiarCampos()
        {
            txtClaveCliente.Clear();
            txtNombreCliente.Clear();
            txtApellidoPat.Clear();
            txtApellidoMat.Clear();
            txtRazonSocial.Clear();
            txtNombreComercial.Clear();
            txtCURP.Clear();
            txtRFC.Clear();
            txtxNumeroTelefono.Clear();
            txtEmail.Clear();
            txtCalle.Clear();
            txtCP.Clear();
            txtNumExterior.Clear();
            txtColonia.Clear();
            txtEstado.Clear();
            txtMunicipio.Clear();
            txtPais.Clear();
            chkStatus.Checked = true;
        }

        public void BindeoCliente(ClienteContacto oClienteContactoBin)
        {
            limpiarCampos();
            oCliente = oClienteContactoBin;

            txtClaveCliente.Text = Convert.ToString(oCliente.sClave);
            txtNombreCliente.Text = Convert.ToString(oCliente.sNombre);
            txtApellidoPat.Text = Convert.ToString(oCliente.sApellidoPat);
            txtApellidoMat.Text = Convert.ToString(oCliente.sApellidoMat);
            txtRazonSocial.Text = Convert.ToString(oCliente.sRazonSocial);
            txtNombreComercial.Text = Convert.ToString(oCliente.sNombreComercial);
            txtCURP.Text = Convert.ToString(oCliente.sCURP);
            txtRFC.Text = Convert.ToString(oCliente.sRFC);
            txtxNumeroTelefono.Text = Convert.ToString(oCliente.nNumeroTelefono);
            txtEmail.Text = Convert.ToString(oCliente.sEmail);
            txtCalle.Text = Convert.ToString(oCliente.sCalle);
            txtCP.Text = Convert.ToString(oCliente.nCodigoPostal);
            txtNumExterior.Text = Convert.ToString(oCliente.nExterior);
            txtColonia.Text = Convert.ToString(oCliente.sColonia);
            txtEstado.Text = Convert.ToString(oCliente.sEstado);
            txtMunicipio.Text = Convert.ToString(oCliente.sMunicipio);
            txtPais.Text = Convert.ToString(oCliente.sPais);
            cmbTipoPersona.SelectedIndex = oCliente.bTipoPersona;
            chkStatus.Checked = oCliente.bTipoPersona == 1 ? chkStatus.Checked = true : chkStatus.Checked = false;
            HabilitarControles();
        }

        public void asignaValores()
        {
            if (eEstatus.Equals(Estatus.Edicion))
            {
                oClienteContacto.nIdCliente01 = oCliente.nIdCliente01;
                oClienteContacto.sClave = oCliente.sClave;
            }
            else
            {
                oClienteContacto.nIdCliente01 = (int)ParameterDirection.Output;
            }
            oClienteContacto.sClave = txtClaveCliente.Text;
            oClienteContacto.sNombre = txtNombreCliente.Text;
            oClienteContacto.sApellidoPat = txtApellidoPat.Text;
            oClienteContacto.sApellidoMat = txtApellidoMat.Text;
            oClienteContacto.sRazonSocial = txtRazonSocial.Text;
            oClienteContacto.sNombreComercial = txtNombreComercial.Text;
            oClienteContacto.sCURP = txtCURP.Text;
            oClienteContacto.sRFC = txtRFC.Text;
            oClienteContacto.nNumeroTelefono = txtxNumeroTelefono.Text;
            oClienteContacto.sEmail = txtEmail.Text;
            oClienteContacto.sCalle = txtCalle.Text;
            oClienteContacto.nCodigoPostal = txtCP.Text;
            oClienteContacto.nExterior = txtNumExterior.Text;
            oClienteContacto.sColonia = txtColonia.Text;
            oClienteContacto.sEstado = txtEstado.Text;
            oClienteContacto.sMunicipio = txtMunicipio.Text;
            oClienteContacto.sPais = txtPais.Text;
            oClienteContacto.bTipoPersona = cmbTipoPersona.SelectedIndex.Equals(1) ? 1 : 0;
            oClienteContacto.bEstatus = chkStatus.Checked ? 1 : 0;
        }


        private void configuracionGridContactos()
        {
            dgvContacto.Columns["IdContacto02"].Visible = false;
            dgvContacto.Columns["ClaveContacto"].Visible = true;
            dgvContacto.Columns["NombreContacto"].Visible = true;
            dgvContacto.Columns["Puesto"].Visible = true;
            dgvContacto.Columns["TelefonoContacto"].Visible = true;
            dgvContacto.Columns["EmailContacto"].Visible = true;
            dgvContacto.Columns["IdClienteContacto"].Visible = false;
            DataGridViewButtonColumn btnEditarContacto = new DataGridViewButtonColumn();
            dgvContacto.Columns.Add(btnEditarContacto);
            btnEditarContacto.Name = "Acciones";
            btnEditarContacto.Text = "Editar";
            btnEditarContacto.UseColumnTextForButtonValue = true;
        }

        public bool validaCampos()
        {
            bool bValida = true;
            try
            {
                //Nombre
                if (cmbTipoPersona.SelectedIndex.Equals(0) && txtNombreCliente.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtNombreCliente, "Debe capturar un nombre de cliente");
                }
                else
                {
                    errorDatos.SetError(txtNombreCliente, string.Empty);
                }
                //Apellido paterno
                if (cmbTipoPersona.SelectedIndex.Equals(0) && txtApellidoPat.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtApellidoPat, "Debe capturar el Apellido paterno del cliente");
                }
                else
                {
                    errorDatos.SetError(txtApellidoPat, string.Empty);
                }
                //Apellido materno
                if (cmbTipoPersona.SelectedIndex.Equals(0) && txtApellidoMat.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtApellidoMat, "Debe capturar el Apellido materno del cliente");
                }
                else
                {
                    errorDatos.SetError(txtApellidoMat, string.Empty);
                }

                //Razon social
                if (cmbTipoPersona.SelectedIndex.Equals(1) && txtRazonSocial.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtRazonSocial, "Debe capturar la Razon social del cliente");
                }
                else
                {
                    errorDatos.SetError(txtRazonSocial, string.Empty);
                }
                //Nombre Comercial
                if (txtNombreComercial.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtNombreComercial, "Debe capturar el Nombre Comercial del cliente");
                }
                else
                {
                    errorDatos.SetError(txtNombreComercial, string.Empty);
                }
                //RFC
                if (txtRFC.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtRFC, "Debe capturar el RFC del cliente");
                }
                else
                {
                    errorDatos.SetError(txtRFC, string.Empty);
                }
                //calle 
                if (txtCalle.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtCalle, "Debe capturar la calle del cliente");
                }
                else
                {
                    errorDatos.SetError(txtCalle, string.Empty);
                }
                //numero exterior
                if (txtNumExterior.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtNumExterior, "Debe capturar el numero exterior de la direccion cliente");

                }
                else
                {
                    errorDatos.SetError(txtNumExterior, string.Empty);
                }
                //Codigo Postal
                if (txtCP.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtCP, "Debe capturar el Codigo Postal de la direccion del cliente");
                }
                else
                {
                    errorDatos.SetError(txtCP, string.Empty);
                }

                //Pais
                if (txtPais.Text.Trim().Length == 0)
                {
                    bValida = false;
                    errorDatos.SetError(txtPais, "Debe capturar un pais del cliente");
                }
                else
                {
                    errorDatos.SetError(txtPais, string.Empty);
                }

                return bValida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListaContactosPorIdClientes(int idCliente)
        {

            ClienteContactoBL BL = new ClienteContactoBL();

            try
            {

                listContactos = BL.ContactoPorId(idCliente);

                if (listContactos.Count>0)
                {
                    dgvContacto.Visible = true;
                    dgvContacto.DataSource = listContactos;
                    configuracionGridContactos();
                    if (eEstatus.Equals(Estatus.Edicion))
                    {
                        btnAgregar.Enabled = true;
                        btnEliminaContacto.Enabled = true;
                        btnReporte.Enabled = true;
                    }
                }
                else
                {
                    dgvContacto.Visible = false;
                    if (eEstatus.Equals(Estatus.Edicion))
                    {
                        btnAgregar.Enabled = true;
                        btnEliminaContacto.Enabled = false;
                        btnReporte.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void BuscaDespuesDeGuardar(int idCliente)
        {
            try
            {
                ClienteContactoBL oClienteById = new ClienteContactoBL();

                oClienteContacto = oClienteById.ClientePorId(idCliente);
                BindeoCliente(oClienteContacto);
                eEstatus = Estatus.Lectura;
                HabilitarControles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsecutivoCliente()
        {
            try
            {
                ClienteContactoBL BL = new ClienteContactoBL();
                oClienteContacto = BL.claveConsecutivo();
                txtClaveCliente.Text = oClienteContacto.sClave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConsecutivoContacto()
        {
            try
            {
                ClienteContactoBL BL = new ClienteContactoBL();
                oContacto = BL.claveConsecutivoContacto();
                sClaveContacto = oContacto.ClaveContacto;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Metodos


        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionaCliente f = new frmSeleccionaCliente();

                    if (f.ShowDialog().Equals(DialogResult.OK))
                    {
                        eEstatus = Estatus.Lectura;
                        BindeoCliente(f.oCliente);
                    }
                ListaContactosPorIdClientes(oCliente.nIdCliente01);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            oCliente = new ClienteContacto();
            eEstatus = Estatus.Nuevo;
            HabilitarControles();
            limpiarCampos();
            ConsecutivoCliente();
            dgvContacto.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteContactoBL BL = new ClienteContactoBL();
            try
            {
                if (validaCampos())
                {
                    if (eEstatus.Equals(Estatus.Nuevo))
                    {
                        asignaValores();
                        BL.GuardarCliente(oClienteContacto, 1);
                        
                    }
                    else if (eEstatus.Equals(Estatus.Edicion))
                    {
                        
                        asignaValores();
                        BL.ActualizarCliente(oClienteContacto, 2);
                       
                    }
                    BuscaDespuesDeGuardar(oClienteContacto.nIdCliente01);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (eEstatus.Equals(Estatus.Nuevo))
            {
                oCliente = new ClienteContacto();
                limpiarCampos();
                eEstatus = Estatus.Ninguno;
                HabilitarControles();
            }
            else if (eEstatus.Equals(Estatus.Edicion))
            {
                asignaValores();
                BuscaDespuesDeGuardar(oClienteContacto.nIdCliente01);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClienteContactoBL BL = new ClienteContactoBL();
                    BL.EliminarPorIdCliente(oCliente.nIdCliente01);
                    limpiarCampos();
                    oCliente = new ClienteContacto();
                    eEstatus = Estatus.Ninguno;
                }
                else
                {
                    eEstatus = Estatus.Lectura;
                }
                HabilitarControles();
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            eEstatus = Estatus.Edicion;
            HabilitarControles();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (eEstatus.Equals(Estatus.Lectura))
            {
                frmReporte oFrmReporte = new frmReporte(oCliente.nIdCliente01);
                oFrmReporte.Show();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void cmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarControles();
            if (cmbTipoPersona.SelectedIndex.Equals(1))
            {
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtNombreCliente.Clear();
            }
            else if (cmbTipoPersona.SelectedIndex.Equals(0)) 
            {
                txtRazonSocial.Clear();
            }

        }

        private void dgvContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idContactoelimina = 0;
                if (eEstatus.Equals(Estatus.Edicion))
                {
                    if (e.RowIndex < 0)
                        return;
                    var senderGrid = (DataGridView)sender;
                    int selectedrowindex = dgvContacto.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvContacto.Rows[selectedrowindex];
                    oContacto.IdContacto02 = Convert.ToInt32(selectedRow.Cells["IdContacto02"].Value.ToString());
                    idContactoelimina = Convert.ToInt32(selectedRow.Cells["IdContacto02"].Value.ToString());
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        oContacto.ClaveContacto = selectedRow.Cells["ClaveContacto"].Value.ToString();
                        oContacto.NombreContacto = selectedRow.Cells["NombreContacto"].Value.ToString();
                        oContacto.Puesto = selectedRow.Cells["Puesto"].Value.ToString();
                        oContacto.TelefonoContacto = selectedRow.Cells["TelefonoContacto"].Value.ToString();
                        oContacto.EmailContacto = selectedRow.Cells["EmailContacto"].Value.ToString();
                        oContacto.IdClienteContacto = Convert.ToInt32(selectedRow.Cells["IdClienteContacto"].Value.ToString());
                        frmContacto f = new frmContacto(oContacto, 2);
                        if (f.ShowDialog().Equals(DialogResult.OK))
                        {
                            ListaContactosPorIdClientes(oCliente.nIdCliente01);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra en modo Edicion. Favor de dar click en el boton de Editar", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void btnEliminaContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (idContactoelimina > 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el cliente?", "Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClienteContactoBL BL = new ClienteContactoBL();
                        BL.EliminarPorIdContacto(idContactoelimina);
                        ListaContactosPorIdClientes(oCliente.nIdCliente01);
                    }

                }
                else
                {
                    MessageBox.Show(" Favor de seleccionar un contacto de la lista", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto oContactoAgrega = new Contacto();
                ConsecutivoContacto();
                oContactoAgrega.ClaveContacto = sClaveContacto;
                frmContacto f = new frmContacto(oContactoAgrega, 1, oCliente.nIdCliente01);
                if (f.ShowDialog().Equals(DialogResult.OK))
                {
                    ListaContactosPorIdClientes(oCliente.nIdCliente01);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Eventos

    }
}
