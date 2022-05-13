
namespace ExamenCC
{
    partial class frmContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancelarCon = new System.Windows.Forms.ToolStripButton();
            this.btnGuardarCon = new System.Windows.Forms.ToolStripButton();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.txtPuestoContacto = new System.Windows.Forms.TextBox();
            this.txtEmailContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorDato = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveContacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelefonoContacto = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelarCon,
            this.btnGuardarCon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(273, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCancelarCon
            // 
            this.btnCancelarCon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelarCon.Image = global::ExamenCC.Properties.Resources.btncancel_image_16;
            this.btnCancelarCon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarCon.Name = "btnCancelarCon";
            this.btnCancelarCon.Size = new System.Drawing.Size(23, 22);
            this.btnCancelarCon.Text = "toolStripButton4";
            this.btnCancelarCon.Click += new System.EventHandler(this.btnCancelarCon_Click);
            // 
            // btnGuardarCon
            // 
            this.btnGuardarCon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardarCon.Image = global::ExamenCC.Properties.Resources.btnGuardar_Image;
            this.btnGuardarCon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarCon.Name = "btnGuardarCon";
            this.btnGuardarCon.Size = new System.Drawing.Size(23, 22);
            this.btnGuardarCon.Text = "toolStripButton5";
            this.btnGuardarCon.Click += new System.EventHandler(this.btnGuardarCon_Click);
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(12, 89);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreContacto.TabIndex = 6;
            // 
            // txtPuestoContacto
            // 
            this.txtPuestoContacto.Location = new System.Drawing.Point(140, 89);
            this.txtPuestoContacto.Name = "txtPuestoContacto";
            this.txtPuestoContacto.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoContacto.TabIndex = 7;
            // 
            // txtEmailContacto
            // 
            this.txtEmailContacto.Location = new System.Drawing.Point(140, 139);
            this.txtEmailContacto.Name = "txtEmailContacto";
            this.txtEmailContacto.Size = new System.Drawing.Size(100, 20);
            this.txtEmailContacto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del contacto(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puesto(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email(*)";
            // 
            // errorDato
            // 
            this.errorDato.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clave";
            // 
            // txtClaveContacto
            // 
            this.txtClaveContacto.Location = new System.Drawing.Point(12, 41);
            this.txtClaveContacto.Name = "txtClaveContacto";
            this.txtClaveContacto.Size = new System.Drawing.Size(100, 20);
            this.txtClaveContacto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Telefono(*)";
            // 
            // txttelefonoContacto
            // 
            this.txttelefonoContacto.Location = new System.Drawing.Point(12, 139);
            this.txttelefonoContacto.Name = "txttelefonoContacto";
            this.txttelefonoContacto.Size = new System.Drawing.Size(100, 20);
            this.txttelefonoContacto.TabIndex = 14;
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelefonoContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClaveContacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailContacto);
            this.Controls.Add(this.txtPuestoContacto);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmContacto";
            this.Text = "Contacto";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelarCon;
        private System.Windows.Forms.ToolStripButton btnGuardarCon;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.TextBox txtPuestoContacto;
        private System.Windows.Forms.TextBox txtEmailContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorDato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelefonoContacto;
    }
}