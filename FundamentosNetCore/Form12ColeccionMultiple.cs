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
    public partial class Form12ColeccionMultiple : Form
    {
        public Form12ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int index in this.lstElementos.SelectedItems)
            {
                indices += index + ",";
            }
            this.lblSeleccionado.Text = indices.Trim(',');
            foreach (int item in this.lstElementos.SelectedIndices)
            {
                items += item + ",";
            }
            this.lblSeleccionado2.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEleminar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS ELIMINAR MULTIPLES ELEMENTOS DENTRO DE LA LISTA
            //ELIMINAREMOS MEDIANTE SU INDEX
            int numSeleccionados = this.lstElementos.SelectedItems.Count;
            for (int i = numSeleccionados; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}
