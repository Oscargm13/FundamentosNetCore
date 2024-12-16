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
    public partial class Form15Metodos : Form
    {
        public Form15Metodos()
        {
            InitializeComponent();
        }

        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        void Cambiarcolor(Button boton)
        {
            boton.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cambiarcolor(this.btnDobleReferencia);
            this.Cambiarcolor(this.btnDobleValor);
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.textBox1.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        void GetDobleReferencia(int num)
        {
            num = num * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.textBox1.Text);
            this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = numero.ToString();

        }
    }
}
