using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_enteros_entre_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTE PROGRAMA LE IMPRIME LOS NUMERO COMPRENDIDOS EN DOS NUMEROS QUE DIGITE");
            int num1, num2;

            Console.WriteLine("Digite el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los numeros comprendidos entre " + num1 + " y " + num2);

            for (int i = num1 + 1 ; i < num2; i++)
            {
                Console.WriteLine( i);
               
                
            }
            Console.ReadKey();

        }
    }
}
