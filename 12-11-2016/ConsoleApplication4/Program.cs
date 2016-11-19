using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = string.Empty;
            string cadena2 = string.Empty;
            string resultado = string.Empty;

            cadena1 = "Erick";

            Console.WriteLine("Escribe una cadena");
            cadena2 = Console.ReadLine();

            resultado = (cadena1 == cadena2) ? "Las cadenas coinciden" : "Las cadenas no coinciden";
            Console.WriteLine(resultado);

            //if (cadena1 == cadena2)
            //{
            //    Console.WriteLine("Las cadenas coinciden");
            //}
            //else
            //    Console.WriteLine("Las cadenas no coinciden");

            Main(null);
        }
    }
}
