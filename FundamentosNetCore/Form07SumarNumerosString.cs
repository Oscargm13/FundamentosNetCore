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
    public partial class Form07SumarNumerosString : Form
    {
        public Form07SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string  textoNumero = this.txtNumeros.Text;
            int     suma = 0;
            char    caracter;

            for (int i = 0; i < textoNumero.Length; i++)
            {
                //RRECUPERAMOS CADA UNO DE LOS CARACTERES
                caracter = textoNumero[i];
                //CONVERTIMOS EL CARACTER A NUMERO
                suma += int.Parse(caracter.ToString());
            }
            this.label2.Text = "La suma es: " + suma;
        }
    }
}
