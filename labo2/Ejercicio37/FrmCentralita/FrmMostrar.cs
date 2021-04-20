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
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipoLlamada;
        private Centralita myCentralita;
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Centralita frmMenuCentralita) : this()
        {
            myCentralita = frmMenuCentralita;
        }

        public Llamada.TipoLlamada SetTipoLlamada
        {
            set
            {
                tipoLlamada = value;
            }
        }
    }
}
