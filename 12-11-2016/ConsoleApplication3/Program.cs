using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = string.Empty;
            string cadena2 = string.Empty;

            cadena1 = "Erick";
            cadena2 = Console.ReadLine();

            if (cadena1 == cadena2)
            {
                Console.WriteLine("Las cadenas coinciden");
            }
            else
                Console.WriteLine("Las cadenas no coinciden");
            
            //Console.ReadLine();

            Main(null);
        }
    }
}
