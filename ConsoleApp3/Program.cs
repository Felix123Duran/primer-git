using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("ingresa un numero para saber si es multiplo de 5 o de 4: ");
            numero=int.Parse(Console.ReadLine());

            if (numero%4==0)
            {
                Console.WriteLine("el numero es multiplo de 4");
            }
            else
            {
                Console.WriteLine("este numero no es multiplo de 4 0");
            }
            if (numero%5==0)
            {
                Console.WriteLine("este numero es multiplo de 5");
            }
            else
            {
                Console.WriteLine("este numero no es mutiplo de 5");
            }
            Console.ReadKey();
        }
    }
}
