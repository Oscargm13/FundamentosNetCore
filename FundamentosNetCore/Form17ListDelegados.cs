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
    public partial class Form17ListDelegados : Form
    {
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            this.botones.Add(this.button1);
            this.botones.Add(this.button2);
            this.botones.Add(this.button3);
            foreach (Button b in this.botones)
            {
                //b.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.textBox1.Text = this.contador.ToString();
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
