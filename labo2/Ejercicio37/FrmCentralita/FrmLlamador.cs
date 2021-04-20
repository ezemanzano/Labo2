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

namespace FrmCentralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita myCentral;

        public FrmLlamador(Centralita frmMenuCentralita)
        {
            this.myCentral = frmMenuCentralita;
            InitializeComponent();
            //  cmbFranja.Enabled = false;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }

        
        public Centralita Centralita
        {
            get
            {
                return this.Centralita;
            }
        }



        private void btnHastag_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnHashtag.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = "Nro Destino";
            txtOrigen.Text = "Nro Origen"; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarNumero(string digitoPresionado)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = string.Empty;
            }
            this.txtDestino.Text += digitoPresionado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button9.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.button0.Text);
        }

        private void btnHashtag_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnHashtag.Text);
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDestino.Text.IndexOf('#')==0)
            {
                this.cmbFranja.Enabled = true;
            }
            else 
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void txtOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo numero", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion= (float)random.Next(1,60);
            Llamada llamada;
            if (this.txtDestino.Text[0] =='#')
            {
                llamada = new Provincial(this.txtOrigen.Text, (Provincial.Franja)this.cmbFranja.SelectedItem, duracion, this.txtDestino.Text);
            }
            else
            {
                float costo = (float)random.Next(1, 100);
                llamada = new Local(this.txtOrigen.Text, duracion, txtDestino.Text, costo);
            }
            this.myCentral += llamada;
        }
    }
}
