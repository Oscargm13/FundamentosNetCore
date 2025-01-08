using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoclases.Models;

namespace proyectoclases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private string path;

        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.path = path;
        }
        private string ConvertirMascotaString()
        {
            string data = "";
            foreach (var item in Mascotas)
            {
                string temp = item.Nombre + "," + item.Raza;
                data += temp + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }
        private void ConvertirMascotasList(string data)
        {
            this.Mascotas.Clear();
            string[] datosMascotas = data.Split("@");
            foreach (string stringMascota in datosMascotas)
            {
                string[] prop = stringMascota.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = prop[0];
                mascota.Raza = prop[1];
            }
        }

        private async Task WriteMascotaAsync()
        {
            string data = this.ConvertirMascotaString();
            await HelpersFiles().WriteAsync(this.path, data);
        }
    }
}
