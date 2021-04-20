using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using FrmCentralita;


namespace FrmCentralita
{
    public partial class FrmMenu : Form
    {
     
        public FrmMenu()
        {
            InitializeComponent();
            
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FrmLlamador callForm = new FrmLlamador(new Centralita("tetuCentralita"));
            callForm.Location = this.Location;
            callForm.ShowDialog();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar showForm = new FrmMostrar(new Centralita("tetuCentralita"));
            showForm.SetTipoLlamada = Llamada.TipoLlamada.Todas;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

       
    }
}
