using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoDeOperacion = 0;
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;

            Console.WriteLine("¿Qué operación vas a realizar?");
            Console.WriteLine("Suma             1");
            Console.WriteLine("Resta            2");
            Console.WriteLine("Multiplicación   3");
            Console.WriteLine("División         4");

            tipoDeOperacion = Convert.ToInt32(Console.ReadLine());

            if (tipoDeOperacion == 1)
            {
                Console.WriteLine("Escribe los dos números para sumar");
                Console.WriteLine("Escribe tu primer número");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de tu suma es igual a: " + resultado);
            }else if (tipoDeOperacion == 2)
            {
                Console.WriteLine("Escribe los dos números para restar");
                Console.WriteLine("Escribe tu primer número");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado de tu resta es igual a: " + resultado);
            }else if (tipoDeOperacion == 3)
            {
                Console.WriteLine("Escribe los dos números para multiplicar");
                Console.WriteLine("Escribe tu primer número");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 * numero2;
                Console.WriteLine("El resultado de tu multiplicación es igual a: " + resultado);
            }else if (tipoDeOperacion == 4)
            {
                Console.WriteLine("Escribe los dos números para dividir");
                Console.WriteLine("Escribe tu primer número");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado de tu división es igual a: " + resultado);
            }
            //String mensajeDeResutado = ("El resultado de la suma es: ");
            //Console.WriteLine(mensajeDeResutado + resultado);

            //Console.ReadLine();

            Main(null);
        }
    }
}
