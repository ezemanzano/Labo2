
namespace WindowsFormsApp1
{
    partial class FrmAltaCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkAplicacion = new System.Windows.Forms.CheckBox();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            this.pnlFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(157, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(157, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(228, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(111, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(157, 83);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(424, 37);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(130, 48);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "&CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(228, 83);
            this.numDni.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(120, 20);
            this.numDni.TabIndex = 7;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(157, 129);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(78, 13);
            this.lblFormaPago.TabIndex = 8;
            this.lblFormaPago.Text = "Forma de pago";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(0, 0);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 9;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Location = new System.Drawing.Point(0, 23);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 10;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkAplicacion
            // 
            this.chkAplicacion.AutoSize = true;
            this.chkAplicacion.Location = new System.Drawing.Point(0, 46);
            this.chkAplicacion.Name = "chkAplicacion";
            this.chkAplicacion.Size = new System.Drawing.Size(75, 17);
            this.chkAplicacion.TabIndex = 11;
            this.chkAplicacion.Text = "Aplicacion";
            this.chkAplicacion.UseVisualStyleBackColor = true;
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.Controls.Add(this.chkAplicacion);
            this.pnlFormaPago.Controls.Add(this.chkTarjeta);
            this.pnlFormaPago.Controls.Add(this.chkEfectivo);
            this.pnlFormaPago.Location = new System.Drawing.Point(259, 121);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Size = new System.Drawing.Size(88, 92);
            this.pnlFormaPago.TabIndex = 12;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Items.AddRange(new object[] {
            "CABA",
            "Mendoza",
            "Cordoba"});
            this.cmbProvincias.Location = new System.Drawing.Point(445, 138);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(108, 21);
            this.cmbProvincias.TabIndex = 13;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAltaCliente";
            this.Text = "Alta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            this.pnlFormaPago.ResumeLayout(false);
            this.pnlFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkAplicacion;
        private System.Windows.Forms.Panel pnlFormaPago;
        private System.Windows.Forms.ComboBox cmbProvincias;
    }
}