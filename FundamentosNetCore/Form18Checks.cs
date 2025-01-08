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
    public partial class Form18Checks : Form
    {
        List<CheckBox> cheks;
        int suma;
        public Form18Checks()
        {
            InitializeComponent();
            this.cheks = new List<CheckBox>();
            this.suma = 0;
            foreach (CheckBox chek in this.panel1.Controls)
            {
                this.cheks.Add(chek);
                //DELEGAMOS LA ACCION DE LOS BOTONES
                chek.Click += SumarNumeros;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.textBox1.Text = suma.ToString();
            //RECORREMOS TODOS LOS BOTONES DE MI COLECCION
            foreach (CheckBox check in this.cheks)
            {
                int numAleat = random.Next(1, 99);
                check.Text = numAleat.ToString();
            }
        }
        void SumarNumeros(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            int numero = int.Parse(b.Text);
            if (b.Checked)
            {
                this.suma += numero;
                this.textBox1.Text = suma.ToString();
            }
            else
            {
                this.suma -= numero;
                this.textBox1.Text = suma.ToString();
            }
        }
    }
}
