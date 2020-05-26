using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_o_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1;
            int numero_2;

            Console.WriteLine("ingrese 2 numeros para saber cual es mas grande");
            Console.WriteLine("primer numero");
            numero_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("primer numero");
            numero_2 = int.Parse(Console.ReadLine());


            if (numero_2 < numero_1)
            {
                Console.WriteLine("el primer numero es mayor");
            }
            else 
            {
                Console.WriteLine("el segundo numero es mayor");
            }
            
     
            
            Console.ReadKey();
        }
    }
}
