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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text.ToUpper();
            int index = lstTienda.Items.IndexOf(elem);
            if (index == -1)
            {
                this.lstTienda.Items.Add(elem);
                this.txtProducto.Clear();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int productosSeleccionados = lstTienda.SelectedIndices.Count;
            for (int i = productosSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.SelectedItems);
            int productosSeleccionados = lstTienda.SelectedIndices.Count;
            for (int i = productosSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
