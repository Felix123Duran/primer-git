using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            //orden  para el usuario
            Console.WriteLine("introdusca dos numeros enteros para dividirlos");
            

            Console.Write("primer numero");
            n=int.Parse(Console.ReadLine());


            Console.Write("segundo numero");
            m = int.Parse(Console.ReadLine());


            if (m==0)
            {
                Console.WriteLine("ERROR NO SE PUEDE DIVIDIR UN NUMERO ENTRE  0");
            }
            else
            {
                Console.WriteLine("la divicion es igual a: " + n / m);
            }

            Console.ReadKey();
        }
    }
}
