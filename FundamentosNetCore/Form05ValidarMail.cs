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
    public partial class Form05ValidarMail : Form
    {
        public Form05ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string entrada = this.txtMail.Text;
            int extension = entrada.Length - entrada.LastIndexOf(".") - 1;

            if (!entrada.Contains("@"))
            {
                lblResultado.Text = "El mail debe contener un '@'.";
            }

            else if (entrada.StartsWith("@") || entrada.EndsWith("@"))
            {
                lblResultado.Text = "El mail no debe comenzar ni terminar con '@'.";
            }

            else if (entrada.Count(c => c == '@') > 1)
            {
                lblResultado.Text = "El mail no debe contener más de un '@'.";
            }

            else if (!entrada.Substring(entrada.IndexOf("@") + 1).Contains("."))
            {
                lblResultado.Text = "Debe haber al menos un '.' después del '@'.";
            }

            else if (extension >= 2 && extension <= 4)
            {
                lblResultado.Text = "La extensión debe tener entre 2 y 4 caracteres.";
            }
            else
            {
                lblResultado.Text = "El mail está validado correctamente.";
            }
        }
    }
}
