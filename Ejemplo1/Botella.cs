using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        //Botella: Capacidad maxima: 100
        //cantidadActual: inicia en cero
        //Metodo recarga: carga al 100 y devuelve el costo de recargar. 50 por cada 100

        //Si no se declara un constructor el ojeto crea uno por defecto
        //Constructor con parametros
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //Sobrecarga de constructor con o sin parametros
        //Si le mandamos parametros tiene que ser diferente al resto de constructores
        public Botella() { }

        //Destructores: en este lenguaje no es tan necesario
        // C# garbaje colector se encarga de eliminar el objeto y devolver la memoria dinamica

        ~Botella()
        {
            //Logica a ejecutar
        }

        //Botella: capacidad, color, material.

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        //Propiedad
        public string Color
        {
            //Lee y modifica
            get { return color; }
            set { color = value; }
        }
        public string Material
        {
            //Solo lectura - no modifica
            get { return material; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //Metodos
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        //Sobrecarga de metodo
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            //100 50
            //cant x=??
            
        }
    }
}
