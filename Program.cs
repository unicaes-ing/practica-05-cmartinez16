using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dias();
            Console.ReadKey();
        }
        static void Dias()
        {
            DateTime Ahora = DateTime.Today;
            String Fecha = "31/Diciembre/2019";
            DateTime Cambio = DateTime.Parse(Fecha);
            TimeSpan Diferencia = Cambio - Ahora;
            int Dias = Diferencia.Days;
            Console.WriteLine("------------Fin de año-------------------");
            Console.WriteLine("Faltan {0:N2} dias para finalizar el año", Dias.ToString());


        }
    }
    }
