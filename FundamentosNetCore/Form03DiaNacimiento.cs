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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            int op1;
            int op2;
            int op3;
            int op4;
            int op5;
            int op6;
            int operacion;

            if(mes == 1)
            {
                mes = 13;
                anyo = anyo - 1;
            }
            else if(mes == 2)
            {
                mes = 14;
                anyo = anyo - 1;
            }

            op1 = ((mes + 1) * 3) / 5;
            op2 = anyo / 4;
            op3 = anyo / 100;
            op4 = anyo / 400;
            op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            op6 = op5 / 7;
            operacion = op5 - op6 * 7;

            lblResultado.Text = operacion.ToString();

        }
    }
}
