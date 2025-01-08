using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoclases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void Form20TestClases_Load(object sender, EventArgs e)
        {

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new proyectoclases.Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Navidad";
            persona.Edad = 25;
            persona.Genero = tipoGenero.femenino;
            persona.Nacionalidad = Paises.España;
            persona.Domicilio.Calle = "Oficina principal de correos";
            persona.Domicilio.Ciudad = "Napapiiri, Finlandia";
            this.lstClases.Items.Add("Nombre: " +
                persona.GetNombreCompleto());
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Genero: "
                + persona.Genero
                + " Nacionalidad: " + persona.Nacionalidad);
            this.lstClases.Items.Add("Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            Director director = new Director();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";
            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            
            this.lstClases.Items.Add("Salario minimo: "+empleado.SalarioMinimo);
            this.lstClases.Items.Add(director);
            this.lstClases.Items.Add("Salario minimo: " + director.SalarioMinimo);
        }
    }
}
