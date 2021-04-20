
namespace ConversorForm
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnCandado = new System.Windows.Forms.Button();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadEuros = new System.Windows.Forms.TextBox();
            this.txtCantidadDolar = new System.Windows.Forms.TextBox();
            this.txtCantidadPesos = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(106, 28);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(56, 13);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // btnCandado
            // 
            this.btnCandado.ImageIndex = 1;
            this.btnCandado.ImageList = this.imageList1;
            this.btnCandado.Location = new System.Drawing.Point(205, 28);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(75, 23);
            this.btnCandado.TabIndex = 1;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(318, 31);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionEuro.TabIndex = 2;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(51, 105);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 3;
            this.lblEuro.Text = "Euro";
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(433, 31);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionDolar.TabIndex = 4;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(556, 31);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionPeso.TabIndex = 5;
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(51, 147);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 6;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(51, 189);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(205, 105);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(75, 23);
            this.btnEuro.TabIndex = 8;
            this.btnEuro.Text = ">";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(205, 147);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 9;
            this.btnDolar.Text = ">";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(205, 189);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(75, 23);
            this.btnPeso.TabIndex = 10;
            this.btnPeso.Text = ">";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Location = new System.Drawing.Point(318, 189);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoEuro.TabIndex = 11;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Location = new System.Drawing.Point(318, 150);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarEuro.TabIndex = 12;
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Location = new System.Drawing.Point(318, 108);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroEuro.TabIndex = 13;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Location = new System.Drawing.Point(433, 108);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroDolar.TabIndex = 14;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Location = new System.Drawing.Point(433, 149);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarDolar.TabIndex = 15;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Location = new System.Drawing.Point(433, 192);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoDolar.TabIndex = 16;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Location = new System.Drawing.Point(556, 110);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroPeso.TabIndex = 17;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Location = new System.Drawing.Point(556, 150);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarPeso.TabIndex = 18;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Location = new System.Drawing.Point(556, 192);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoPeso.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Peso";
            // 
            // txtCantidadEuros
            // 
            this.txtCantidadEuros.Location = new System.Drawing.Point(99, 107);
            this.txtCantidadEuros.Name = "txtCantidadEuros";
            this.txtCantidadEuros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadEuros.TabIndex = 23;
            // 
            // txtCantidadDolar
            // 
            this.txtCantidadDolar.Location = new System.Drawing.Point(99, 150);
            this.txtCantidadDolar.Name = "txtCantidadDolar";
            this.txtCantidadDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDolar.TabIndex = 24;
            // 
            // txtCantidadPesos
            // 
            this.txtCantidadPesos.Location = new System.Drawing.Point(99, 189);
            this.txtCantidadPesos.Name = "txtCantidadPesos";
            this.txtCantidadPesos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPesos.TabIndex = 25;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "45486.png");
            this.imageList1.Images.SetKeyName(1, "61355.png");
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 237);
            this.Controls.Add(this.txtCantidadPesos);
            this.Controls.Add(this.txtCantidadDolar);
            this.Controls.Add(this.txtCantidadEuros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.lblCotizacion);
            this.Name = "FrmPrincipal";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtPesoPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadEuros;
        private System.Windows.Forms.TextBox txtCantidadDolar;
        private System.Windows.Forms.TextBox txtCantidadPesos;
        private System.Windows.Forms.ImageList imageList1;
    }
}

