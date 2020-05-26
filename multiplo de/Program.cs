using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_de
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1, numero_2;

            Console.WriteLine("dijite el numero a dividir (dividendo)");
            numero_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("dijite el  (dicisor)");
            numero_2 = int.Parse(Console.ReadLine());



            if (numero_1 / numero_2 ==0)
            {
                Console.WriteLine("{0} es multiplo de {1}", numero_1, numero_2);

            }
            else
            {
                Console.WriteLine("{0} no es multiplo de {1}", numero_1, numero_2);
            }
            Console.ReadKey();
        }
    }
}
