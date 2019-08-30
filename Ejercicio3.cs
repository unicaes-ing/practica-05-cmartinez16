using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio3
    {
        static int Factorial(int valor)
        {
            int fact = valor;
            for (int i = 1; i < valor; i++)
            {
                fact = fact * (valor - i);

            }

            return fact;
        }
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine("Ingrese un número entero:");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 0);

            Console.WriteLine("El factorial de {0} es {1}", num, Factorial(num));
            Console.ReadKey();


        }
    }
}
