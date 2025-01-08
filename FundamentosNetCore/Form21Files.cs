using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoclases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelpersFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            //CUANDO HABLAMOS DE RUTAS DE FICHEROS CON CARACTERES ESPECIALES TENEMOS DOS POSIBILIDADES
            //this.Path = "C\\carpeta\\file1.txt";
            //this.Path = @"C:\carpeta\file1.txt";
            this.Path = "file1.txt";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);

        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void WriteFile_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Path);
            //CREAMOS EL FICHERO
            using (TextWriter writer = file.CreateText())
            {
                string contenido = this.GetNombresListBox();
                await writer.WriteAsync(contenido);
                //DESPUES DE ESCRIBIR EN CUALQUIER FICHERO SE DEBE APLICAR EL METODO FLUSH()
                await writer.FlushAsync();
                writer.Close();
                MessageBox.Show("Datos almacenados");
            }
            //string data = this.GetNombresListBox();
            //await this.helper.WriteFileAsync(this.Path, data);
            //MessageBox.Show("Datos guardados");

        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {

            }
        }

        private async void ReadFile_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Path);
            using (TextReader reader = file.OpenText())
            {
                string contenido = await reader.ReadToEndAsync();
                reader.Close();
                this.txtContenido.Text = contenido;
            }
        }

        private void RellenarListBox(string nombre)
        {
            string[] data = GetNombresListBox().Split(",");
            this.lstNombres.Items.Clear();
            foreach (string item in data)
            {
                this.lstNombres.Items.Add(item);
            }
        }
    }
}
