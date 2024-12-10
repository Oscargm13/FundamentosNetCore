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

            this.BackColor = Color.FromArgb(Rojo, Verde, Azul);
        }
    }
}
