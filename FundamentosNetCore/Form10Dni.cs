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
    public partial class Form10Dni : Form
    {
        public Form10Dni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni =  txtDni.Text;
            //int numero = int.Parse(dni.ToString());

            string operacion = "";
            for (int i = 0; i < dni.Length; i++)
            {
                if (char.IsDigit(dni[i]))
                {
                    char caracter = dni[i];
                    operacion += caracter;
                }
            }
            int numero = int.Parse(operacion.ToString());
            numero = numero - (numero/23) * 23;
            lblCorrecto.Text = numero.ToString();
        }
    }
}
