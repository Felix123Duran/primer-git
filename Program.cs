using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            int numero_entero;

            //entrada del numero
            Console.WriteLine("introdusca un numero entero");
            numero_entero = int.Parse(Console.ReadLine());

            //controlador

            if (numero_entero%2==0)
            {
                Console.WriteLine("este numero es par");
            }
            else
            {
                Console.WriteLine("este numero no es par");
            }

            Console.ReadKey();
        }
    }
}
