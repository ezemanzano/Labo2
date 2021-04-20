using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace ConversorForm
{
    public partial class FrmPrincipal : Form
    {
        Euro euro;
        Peso peso;
        Dolar dolar;


        public FrmPrincipal()
        {
            InitializeComponent();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
        }

        

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (btnCandado.ImageIndex==1)
            {
                btnCandado.ImageIndex = 0;
                Peso.SetCotizacion((double.Parse)(txtCotizacionPeso.Text));
                Euro.SetCotizacion((double.Parse)(txtCotizacionEuro.Text));
                Dolar.SetCotizacion((double.Parse)(txtCotizacionDolar.Text));
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnCandado.ImageIndex = 1;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }

            ;

        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            euro = new Euro(double.Parse(txtCantidadEuros.Text));
            peso = (Peso)euro;
            dolar = (Dolar)euro;
            txtEuroEuro.Text = (euro.GetCantidad()).ToString();
            txtEuroDolar.Text = (dolar.GetCantidad()).ToString();
            txtEuroPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            dolar = new Dolar(double.Parse(txtCantidadDolar.Text));
            peso = (Peso)dolar;
            euro = (Euro)dolar;
            txtDolarDolar.Text = (dolar.GetCantidad()).ToString();
            txtDolarPeso.Text = (peso.GetCantidad()).ToString();
            txtDolarEuro.Text = (euro.GetCantidad()).ToString();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            peso = new Peso(double.Parse(txtCantidadPesos.Text));
            dolar = (Dolar)peso;
            euro = (Euro)peso;
            txtPesoPeso.Text = (peso.GetCantidad()).ToString();
            txtPesoDolar.Text = (dolar.GetCantidad()).ToString();
            txtPesoEuro.Text = (euro.GetCantidad()).ToString();
        }
    }
}
