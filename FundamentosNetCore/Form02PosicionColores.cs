using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtPosicionX.Text);
            int y = int.Parse(this.txtPosicionY.Text);
            
            this.btnCambiarPosicion.Location = new Point(x, y);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int Rojo = int.Parse(this.txtRojo.Text);
            int Verde = int.Parse(this.txtVerde.Text);
            int Azul = int.Parse(this.txtAzul.Text);
            if (Rojo > 255 || Rojo < 0)
            {
                MessageBox.Show(
                    "El valor de rojo tiene que estar entre 0 y 255"
                    );
            }
            else if (Verde > 255 || Verde < 0)
            {
                MessageBox.Show(
                    "El valor de Verde tiene que estar entre 0 y 255"
                    );
            }else if (Azul > 255 || Azul < 0)
            {
                MessageBox.Show(
                    "El valor de Azul tiene que estar entre 0 y 255"
                    );
            }else
            {
                this.BackColor = Color.FromArgb(Rojo, Verde, Azul);
            }
            
        }
    }
}
