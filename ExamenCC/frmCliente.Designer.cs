
namespace ExamenCC
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReporte = new System.Windows.Forms.Button();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.txtxNumeroTelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoMat = new System.Windows.Forms.Label();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.lblApellidoPat = new System.Windows.Forms.Label();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.txtNumExterior = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminaContacto = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.btnCancelar,
            this.btnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::ExamenCC.Properties.Resources.btnnew_image_16;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "toolStripButton1";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::ExamenCC.Properties.Resources.btnEdit_Images_161;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::ExamenCC.Properties.Resources.btndelete_image_16;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "toolStripButton3";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::ExamenCC.Properties.Resources.btncancel_image_16;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "toolStripButton4";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::ExamenCC.Properties.Resources.btnGuardar_Image;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "toolStripButton1";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(660, 443);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(89, 23);
            this.btnReporte.TabIndex = 24;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.txtMunicipio);
            this.gpCliente.Controls.Add(this.lblMunicipio);
            this.gpCliente.Controls.Add(this.txtxNumeroTelefono);
            this.gpCliente.Controls.Add(this.label12);
            this.gpCliente.Controls.Add(this.label5);
            this.gpCliente.Controls.Add(this.txtEmail);
            this.gpCliente.Controls.Add(this.txtPais);
            this.gpCliente.Controls.Add(this.label8);
            this.gpCliente.Controls.Add(this.txtEstado);
            this.gpCliente.Controls.Add(this.label7);
            this.gpCliente.Controls.Add(this.txtColonia);
            this.gpCliente.Controls.Add(this.label6);
            this.gpCliente.Controls.Add(this.label4);
            this.gpCliente.Controls.Add(this.txtRFC);
            this.gpCliente.Controls.Add(this.txtCP);
            this.gpCliente.Controls.Add(this.label1);
            this.gpCliente.Controls.Add(this.label11);
            this.gpCliente.Controls.Add(this.txtNombreComercial);
            this.gpCliente.Controls.Add(this.cmbTipoPersona);
            this.gpCliente.Controls.Add(this.chkStatus);
            this.gpCliente.Controls.Add(this.label10);
            this.gpCliente.Controls.Add(this.btnBuscar);
            this.gpCliente.Controls.Add(this.lblRazonSocial);
            this.gpCliente.Controls.Add(this.txtClaveCliente);
            this.gpCliente.Controls.Add(this.txtRazonSocial);
            this.gpCliente.Controls.Add(this.txtNombreCliente);
            this.gpCliente.Controls.Add(this.lblApellidoMat);
            this.gpCliente.Controls.Add(this.txtApellidoMat);
            this.gpCliente.Controls.Add(this.lblApellidoPat);
            this.gpCliente.Controls.Add(this.txtApellidoPat);
            this.gpCliente.Controls.Add(this.txtNumExterior);
            this.gpCliente.Controls.Add(this.label9);
            this.gpCliente.Controls.Add(this.txtCalle);
            this.gpCliente.Controls.Add(this.txtCURP);
            this.gpCliente.Controls.Add(this.lblNombre);
            this.gpCliente.Controls.Add(this.label2);
            this.gpCliente.Controls.Add(this.label3);
            this.gpCliente.Location = new System.Drawing.Point(12, 31);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(673, 298);
            this.gpCliente.TabIndex = 33;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "Cliente";
            // 
            // txtxNumeroTelefono
            // 
            this.txtxNumeroTelefono.Location = new System.Drawing.Point(9, 226);
            this.txtxNumeroTelefono.Name = "txtxNumeroTelefono";
            this.txtxNumeroTelefono.Size = new System.Drawing.Size(192, 20);
            this.txtxNumeroTelefono.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(544, 269);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(111, 20);
            this.txtPais.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(408, 269);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(118, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Estado";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(408, 226);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(118, 20);
            this.txtColonia.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Colonia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "RFC(*)";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(192, 183);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(160, 20);
            this.txtRFC.TabIndex = 8;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(544, 183);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(86, 20);
            this.txtCP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Codigo Postal(*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Nombre Comercial(*)";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(8, 140);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(344, 20);
            this.txtNombreComercial.TabIndex = 6;
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "FÍSICA",
            "MORAL"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(141, 44);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPersona.TabIndex = 64;
            this.cmbTipoPersona.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersona_SelectedIndexChanged);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(141, 24);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 63;
            this.chkStatus.Text = "Activo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Clave";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ExamenCC.Properties.Resources.btnBuscar_Image_162;
            this.btnBuscar.Location = new System.Drawing.Point(67, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 20);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(6, 71);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 13);
            this.lblRazonSocial.TabIndex = 60;
            this.lblRazonSocial.Text = "Razon Social(*)";
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.Location = new System.Drawing.Point(9, 45);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.Size = new System.Drawing.Size(52, 20);
            this.txtClaveCliente.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(9, 86);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(344, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(8, 86);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(191, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblApellidoMat
            // 
            this.lblApellidoMat.AutoSize = true;
            this.lblApellidoMat.Location = new System.Drawing.Point(472, 71);
            this.lblApellidoMat.Name = "lblApellidoMat";
            this.lblApellidoMat.Size = new System.Drawing.Size(96, 13);
            this.lblApellidoMat.TabIndex = 58;
            this.lblApellidoMat.Text = "Apellido Materno(*)";
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.Location = new System.Drawing.Point(475, 86);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(188, 20);
            this.txtApellidoMat.TabIndex = 5;
            // 
            // lblApellidoPat
            // 
            this.lblApellidoPat.AutoSize = true;
            this.lblApellidoPat.Location = new System.Drawing.Point(240, 70);
            this.lblApellidoPat.Name = "lblApellidoPat";
            this.lblApellidoPat.Size = new System.Drawing.Size(103, 13);
            this.lblApellidoPat.TabIndex = 56;
            this.lblApellidoPat.Text = "Apellido Pataterno(*)";
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.Location = new System.Drawing.Point(243, 86);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(188, 20);
            this.txtApellidoPat.TabIndex = 4;
            // 
            // txtNumExterior
            // 
            this.txtNumExterior.Location = new System.Drawing.Point(408, 183);
            this.txtNumExterior.Name = "txtNumExterior";
            this.txtNumExterior.Size = new System.Drawing.Size(86, 20);
            this.txtNumExterior.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "CURP";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(408, 140);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(247, 20);
            this.txtCalle.TabIndex = 11;
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(9, 183);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(150, 20);
            this.txtCURP.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 13);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Calle(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "No. Exterior(*)";
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(12, 335);
            this.dgvContacto.MultiSelect = false;
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.ReadOnly = true;
            this.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacto.Size = new System.Drawing.Size(642, 191);
            this.dgvContacto.TabIndex = 34;
            this.dgvContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacto_CellContentClick);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(544, 226);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(111, 20);
            this.txtMunicipio.TabIndex = 15;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(541, 210);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(52, 13);
            this.lblMunicipio.TabIndex = 82;
            this.lblMunicipio.Text = "Municipio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(660, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 23);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminaContacto
            // 
            this.btnEliminaContacto.Location = new System.Drawing.Point(660, 380);
            this.btnEliminaContacto.Name = "btnEliminaContacto";
            this.btnEliminaContacto.Size = new System.Drawing.Size(89, 23);
            this.btnEliminaContacto.TabIndex = 84;
            this.btnEliminaContacto.Text = "Elimina";
            this.btnEliminaContacto.UseVisualStyleBackColor = true;
            this.btnEliminaContacto.Click += new System.EventHandler(this.btnEliminaContacto_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 529);
            this.Controls.Add(this.btnEliminaContacto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvContacto);
            this.Controls.Add(this.gpCliente);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ErrorProvider errorDatos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.Label lblApellidoPat;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.TextBox txtNumExterior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtxNumeroTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Button btnEliminaContacto;
        private System.Windows.Forms.Button btnAgregar;
    }
}

