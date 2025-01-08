using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoclases
{
    public class Director
    {
        public int SalarioMinimo { get; set; }
        public Director() {
            Debug.WriteLine("Constructor DIRECTOR vacío");
            
            this.SalarioMinimo = 1200;
        }

        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return 30;
        }
    }
}
