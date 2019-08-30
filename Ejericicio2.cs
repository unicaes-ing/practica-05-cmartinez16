using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejericicio2
    {
        static int Valor(int numero)
        {
            return numero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("El número ingresado es 0");
            }
            if (num < 0)
            {
                Console.WriteLine("El número {0} es negativo", Valor(num));
            }
            if (num > 0)
            {
                Console.WriteLine("El número {0} es positivo", Valor(num));
            }
            Console.ReadKey();

        }
    }
}
