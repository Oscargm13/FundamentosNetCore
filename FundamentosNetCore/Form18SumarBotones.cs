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
    public partial class Form18SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form18SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            //ALMACENAMOS TODOS LOS CONTROLES DEL PANEL DENTRO DE NUESTRA COLECCION
            foreach (Button b in this.panel1.Controls)
            {
                this.botones.Add(b);
                //DELEGAMOS LA ACCION DE LOS BOTONES
                b.Click += SumarNumeros;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.textBox1.Text = suma.ToString();
            //RECORREMOS TODOS LOS BOTONES DE MI COLECCION
            foreach (Button b in this.botones)
            {
                int numAleat = random.Next(1, 99);
                b.Text = numAleat.ToString();
            }
        }
        void SumarNumeros(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int numero = int.Parse(b.Text);
            this.suma += numero;
            this.textBox1.Text = suma.ToString();
        }
    }
}
