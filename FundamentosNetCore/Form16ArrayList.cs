using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();
            List<Button> coleccion = new List<Button>();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //coleccion.Add(this.txtDato);

            ArrayList botones = new ArrayList();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.txtDato);

            ((Button)coleccion[0]).BackColor = Color.Yellow;
            foreach(Button boton in coleccion)
            {
                boton.BackColor = Color.Red;
                

            }
            this.button1.Click += MetodoDelegado;
        }

        void MetodoDelegado(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
