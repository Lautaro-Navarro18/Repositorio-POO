using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
            int num1, num2, num3;
            Console.Write("escriba su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("segundo: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("tercero y ultimo: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine(num3 * (num1 + num2));
            }
            else
            {
                Console.Write("ta gaga");
            }
            Console.ReadKey();
        }
    }
}
