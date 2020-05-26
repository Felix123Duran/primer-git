using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1, numero_2;

            Console.WriteLine("introdusca un numero entero para provar si es o no multiplo de 10");
            numero_1 = int.Parse(Console.ReadLine());

            //de aqui en adelante son conectores que guiaran al usuario
            if (numero_1 % 10 == 0)
            {
                Console.WriteLine("{0} es multiplo de 10", numero_1);
                Console.ReadLine();


                Console.WriteLine("verifique con otro numero que sea o no multiplo de 10");
                numero_2 = int.Parse(Console.ReadLine());


                //segunda verificacion del numero dentro del mismo "if"
                if (numero_2 % 10 == 0)
                {
                    Console.WriteLine("este numero tambien es multiplo de 10 ");
                }
                else
                {
                    Console.WriteLine("este numero no es multiplo de 10");
                }


            }
            else
            {
                Console.WriteLine("este numero no es multiplo de 10 ");

                Console.WriteLine("verifique con otro numero que sea o no multiplo de 10");
                numero_1 = int.Parse(Console.ReadLine());

                if (numero_1 % 10 == 0)
                {
                    Console.WriteLine("{0} es multiplo de 10", numero_1);
                   

                }



                Console.ReadKey();
            }
        }
    }
}
