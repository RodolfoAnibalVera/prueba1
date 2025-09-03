using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Persona---------

            //Persona: Edad, sueldo, nombre
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //Persona p1 = new Persona("Rodo");
            //p1.setEdad(20);

            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Pepe"));
            //Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            // --------Botella----------------

            Botella b1 = new Botella("Rojo", "Plastico");
            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);


            //b1.Capacidad = 200;
            //int capBot1 = b1.Capacidad;

            //b1.Color = "Natural";

            //int algo = b1.Capacidad;
            //Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad + "ml");

            //Objeto Botella sin parametros
            //Botella b2 = new Botella();

            //-----------Perro-----------------

            //Perro dog1 = new Perro();
            //dog1.Nombre = "Blako";
            //string dogname = dog1.Nombre;
            //Console.WriteLine("El nombre del perro es: " + dog1.Nombre);

            //----Truco ToString(0.00)-----------
            //Formatea valor a 2 decimales (1.23)
            //float valor = 1.233333f;
            //Console.WriteLine(valor.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
