using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, sueldo, nombre
        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {  
            edad = e; 
        }

        public int getEdad()
        {
            return edad;
        }
        public string saludar()
        { 
            return "Hola soy..." + nombre; 
        }

        //Saludar sobrecargado
        public string saludar(string personaje)
        {
            // si el argumento que recibe es igual al de la propiedad, a este ultimo se le agrega un this.
            // ej: return "Hola " + personaje + ", soy... " + this.nombre;
            return "Hola " + personaje + ", soy... " + nombre;
        }
    }
}
