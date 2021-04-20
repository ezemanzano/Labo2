
namespace Ejercicio28
{
    partial class FrmDiccionario
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
            this.rtbDiccionario = new System.Windows.Forms.RichTextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDiccionario
            // 
            this.rtbDiccionario.Location = new System.Drawing.Point(104, 28);
            this.rtbDiccionario.Name = "rtbDiccionario";
            this.rtbDiccionario.Size = new System.Drawing.Size(384, 215);
            this.rtbDiccionario.TabIndex = 0;
            this.rtbDiccionario.Text = "";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(413, 268);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 40);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // FrmDiccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.rtbDiccionario);
            this.Name = "FrmDiccionario";
            this.Text = "Diccionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDiccionario;
        private System.Windows.Forms.Button btnLeer;
    }
}

