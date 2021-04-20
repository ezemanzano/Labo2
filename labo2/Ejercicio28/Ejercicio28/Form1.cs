using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class FrmDiccionario : Form
    {
        public FrmDiccionario()
        {
            InitializeComponent();
        }

        Dictionary<string, int> diccionario = new Dictionary<string, int>();

        public void LeerTexto()
        {
            for (int i = 0; i < rtbDiccionario.Text.Length; i++)
            {
                int palabras = 0;
                if(rtbDiccionario.Text[i]==' ')
                {
                    diccionario.Add()
                }
            }
           

        }


    }
}
