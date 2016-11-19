using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;

            Console.WriteLine("Escribe tu primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe tu segundo número");
            numero2= Convert.ToInt32(Console.ReadLine());

            resultado = numero1 + numero2;

            if (resultado >= 50)
                Console.WriteLine("Tu resultado es mayor a 50");
            else
                Console.WriteLine("Tu resultado es menor a 50");

            String mensajeDeResutado = ("El resultado de la suma es: ");
            Console.WriteLine(mensajeDeResutado + resultado);

            Console.ReadLine();
        }
    }
}
