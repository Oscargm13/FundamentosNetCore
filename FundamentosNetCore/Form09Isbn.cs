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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string ISBN = this.txtISBN.Text;
            int suma = 0;
            int resultado = 0;

            if(ISBN.Length == 10)
            {
                for(int i = 0; i < ISBN.Length; i++)
                {
                    char caracter = ISBN[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;
                }
                if (resultado % 11 == 0)
                {
                    this.lblCorrecto.Text = "EL ISBN ES CORRECTO!!!";
                }else
                {
                    this.lblCorrecto.Text = "EL ISBN NO SE HA VALIDADO CORRECTAMENTE";
                }
            }else
            {
                this.lblCorrecto.Text = "EL ISBN NO TIENE 10 CARACTERES";
            }
        }
    }
}
