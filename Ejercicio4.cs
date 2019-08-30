using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio4
    {
        static string Telefono(string num1, string num2, string num3, string num4)
        {
            int nombre;
            Random lista = new Random();
            nombre = lista.Next(0, 7);
            return nombre.ToString();

        }
        static void Main(string[] args)
        {

            string num1, num2, num3, num4, numeros;

            Console.WriteLine("Ingrese el 1er numero de telefono");
            num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el 2do numero de telefono");
            num2 = Console.ReadLine();
            Console.WriteLine("Ingrese el 3er numero de telefono");
            num3 = Console.ReadLine();
            Console.WriteLine("Ingrese el 4to numero de telefono");
            num4 = Console.ReadLine();
            numeros = Telefono(num1, num2, num3, num4);
            Console.WriteLine(numeros);
            Console.ReadKey();


        }
    }
}
