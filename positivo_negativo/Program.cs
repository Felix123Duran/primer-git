using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positivo_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;


            //orden para el ususario
            Console.WriteLine("introdusca 2 numeros enteros ");
            //entrada de datos   
            Console.Write("primer numero");
            a = int.Parse(Console.ReadLine());

            Console.Write("segundo numero");
            b = int.Parse(Console.ReadLine());



            //desiciones 1
            if (a>0)
            {
                Console.WriteLine("{0} es positivo", a);
            }
            else
            {
                Console.WriteLine("{0} es negativo",a);
            }
            //desicion 2
            if (b > 0)
            {
                Console.WriteLine("{0} es positivo", b);
            }
            else
            {
                Console.WriteLine("{0} es negativo", b);
            }




            Console.ReadKey();
        }
    }
}
