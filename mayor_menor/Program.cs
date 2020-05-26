using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad=3, numero, mayor = 0, menor=0;

            Console.WriteLine("a continuacion dijite 3 numeros");
            for (int i = 0; i < cantidad;)
            {
                Console.WriteLine("dijite el numero");
                numero = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    mayor = numero;
                }
                else if(i!=0)
                {
                    if (numero<menor)
                    {
                        menor = numero;
                    }
                    if (numero> mayor)
                    {
                        mayor = numero;
                    }
                }

            }

            Console.WriteLine("el numero mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
