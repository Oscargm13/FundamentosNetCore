using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoclases
{
    
    public enum tipoGenero { Masculino, femenino }
    public enum Paises { España, Francia, Alemania, Andorra, Tabarnia }
    public class Persona
    {
        public Persona() {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.Domicilio = new Direccion();
        }
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor persona");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #region PROPIEDADES
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        private tipoGenero _Genero;
        public tipoGenero Genero
        {
            get { return this._Genero; }
            
            set
            {
                if (value != tipoGenero.Masculino && value != tipoGenero.femenino)
                {
                    throw new Exception("Valor de genero incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                if (value < 0)
                {
                    //ºthis._Edad = 0;
                    throw new Exception("La edad no debe de ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion
        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        
        public string GetNombreCompletoAlreves()
        {
            return this.Apellidos + " " + this.Nombre;
        }
        #endregion

    }
}
