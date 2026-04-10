using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: 
             * número de cuenta y saldo actual. El ingreso de datos debe
             * finalizar al ingresar un valor negativo en el número de cuenta.
             * Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
             * a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
             * que:
             * Estado de la cuenta:
             * “Acreedor” si el saldo es > 0.
             * “Deudor” si el saldo es < 0.
             * “Nulo” si el saldo es = 0.
             * b) La suma total de los saldos acreedores.*/
            int numC, salA = 0, suma = 0;
            bool es = true;
            while (es)
            {
                Console.Write("\nIngrese el numero de cuenta: ");
                numC = int.Parse(Console.ReadLine());
                if (numC > -1)
                {
                    Console.Write("Ingrese el saldo actual: ");
                    salA = int.Parse(Console.ReadLine());
                    if (salA > 0)
                    {

                        Console.Write("La cuenta N° " + numC + " es un Acreedor con un saldo de: " + salA);
                        suma = suma + salA;
                    }
                    else
                    {
                        if (salA < 0)
                        {
                            Console.Write("La cuenta N° " + numC + " es un Deudor con saldo de: " + salA);
                        }
                        else
                        {
                            Console.Write("La cuenta N° " + numC + " es Nula: " + salA);
                        }
                    }
                }
                else
                {
                    es = false;
                }
            }
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
