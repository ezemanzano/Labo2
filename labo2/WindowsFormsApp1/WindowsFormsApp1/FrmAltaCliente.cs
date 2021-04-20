using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class1;

namespace WindowsFormsApp1
{
    public partial class FrmAltaCliente : Form
    {
        private Cliente nuevo;
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        { 
            // CheckBox
            string[] formasPago = new string[0];
            string provincias = string.Empty;
            foreach (Control miControl in this.pnlFormaPago.Controls)
            {
                if (miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasPago, formasPago.Length + 1);
                    formasPago[formasPago.Length - 1] = ((CheckBox)miControl).Text;
                }
                
            }

            // comboBox

            if (this.cmbProvincias.SelectedIndex == -1 )
            {
                if (this.cmbProvincias.Text != string.Empty)
                {
                    provincias = this.cmbProvincias.Text;
                }
            }
            else
            {
                provincias = this.cmbProvincias.SelectedItem.ToString();
            }


            this.nuevo = new Cliente(this.txtNombre.Text, this.txtApellido.Text, (long)this.numDni.Value, formasPago , provincias) ;
            this.DialogResult= DialogResult.OK;

           
        }

        public Cliente GetCliente()
        {
            return this.nuevo;
        }

    }
}
