using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoclases
{
    public class Empleado: Persona
    {
        public int SalarioMinimo { get; set; }
        public Empleado() {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1400;
        }

        public Empleado(string nombre, string apellidos):base(nombre, apellidos) {
            Debug.WriteLine("Constructor Empleado");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

    }
}
