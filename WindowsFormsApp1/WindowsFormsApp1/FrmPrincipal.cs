using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper;
namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente();
            frmAlta.ShowDialog();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                
                MiniSuper.MiniSuper.AgregarUsuario(frmAlta.GetCliente());

            }

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = MiniSuper.MiniSuper.GetUsuarios();
            
        }
        /*
         * Crea un form cuando se pasa el mouse por arriba del boton.
        private void btnNuevoCliente_MouseLeave(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente();
            frmAlta.Show();
        }
        //*/

    }
}
