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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexSeleccionado =
                  this.lstElementos.SelectedIndex;
                  this.lstElementos.Items.RemoveAt(indexSeleccionado);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblSeleccionado.Text = "Index seleccionado: " + this.lstElementos.SelectedIndex;
                this.lblSeleccionado.Text = "Index: " + this.lstElementos.SelectedItems;
            }
        }
    }
}
