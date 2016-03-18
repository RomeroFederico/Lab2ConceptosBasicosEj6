using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_6
{
    /*
    06.  Escribir un programa que determine si un año es bisiesto. 
    Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 
    no son bisiestos, salvo si ellos también son múltiplos de 400. 
    Por ejemplo: el año 2000 es bisiesto pero 1900 no.
    Nota: Utilizar estructuras repetitivas, selectivas y la función 
    módulo (%).
    */

    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            int year;

            Console.Title = "Ejercicio Nro. 6";

            Console.Write("Ingrese un año: ");

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Clear();
                Console.Write("ERROR!!! no se ha ingresado un numero. Ingrese un año: ");
            }

            Console.Clear();

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("El año " + year + " es bisiesto. ");
            else
                Console.WriteLine("El año " + year + " no es bisiesto. ");

            Console.ReadKey();
        }
    }
}
