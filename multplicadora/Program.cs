 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multplicadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1,numero_2;

            Console.WriteLine("introduce un numero entero para multiplicarlo por otro");
            numero_1 = int.Parse(Console.ReadLine());

            if (numero_1==0)
            {
                Console.WriteLine("0 por cualquier numero siempre sera 0");
            }
            else
            {
                Console.WriteLine("introdusca otro numero para multiplicar ");
                numero_2 = int.Parse(Console.ReadLine());

                Console.WriteLine(" es: "+numero_2 * numero_1);
            }


                Console.ReadKey();
        }
    }
}
