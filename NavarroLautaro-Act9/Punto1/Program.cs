using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Escuela
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/
        private int[] nota;
        private string[] alumno;
        void cargarAN()
        {
            nota = new int[6];
            alumno = new string[6];
            Console.WriteLine("Ingrese al alumno y su nota: ");
            for(int i = 0; i < nota.Length; i++)
            {
                alumno[i] = Console.ReadLine();
                nota[i] = int.Parse(Console.ReadLine());
            }
        }
        void EstuA()
        {
            int[] nom;
            int ubi = 0, aux = nota[0], repeA = 1;
            for (int i = 0; i < nota.Length - 1; i++)
            {
                if (aux == nota[i + 1])
                {
                    repeA++;
                }
                if (nota[i + 1] > aux)
                {
                    aux = nota[i + 1];
                    ubi = i + 1;
                    repeA = 1;
                }
            }
            nom = new int[repeA];
            int A=0;
            for (int i = 0; i < nota.Length-1; i++)
            {
                if (nota[i + 1] == aux)
                {
                    nom[A] = i + 1;
                    A++;
                }
            }
            if (repeA > 1)
            {
                Console.Write("Los estudiantes: ");
                for(int i = 0; i < nom.Length; i++)
                {
                    Console.Write(alumno[nom[i]] + ",");
                }
                Console.Write(" tubieron la nota mas alta con " + aux + " y en total fueron " + repeA);
            }
        }
        void EstuB()
        {
            int[] nom;
            int ubi = 0, aux = nota[0], repeB = 1;
            for (int i = 0; i < nota.Length - 1; i++)
            {
                if (aux == nota[i + 1])
                {
                    repeB++;
                }
                if (nota[i + 1] < aux)
                {
                    aux = nota[i + 1];
                    ubi = i + 1;
                    repeB = 1;
                }
            }
            nom = new int[repeB];
            int A = 0;
            for (int i = 0; i < nota.Length - 1; i++)
            {
                if (nota[i + 1] == aux)
                {
                    nom[A] = i + 1;
                    A++;
                }
            }
            if (repeB > 1)
            {
                Console.Write("Los estudiantes: ");
                for (int i = 0; i < nom.Length; i++)
                {
                    Console.Write(alumno[nom[i]] + ",");
                }
                Console.Write(" tuvieron la nota mas baja con " + aux + " y en total fueron " + repeB);
            }
            els
            {
                Console.Write("El estudiantes: ");
                for (int i = 0; i < nom.Length; i++)
                {
                    Console.Write(alumno[nom[i]]);
                }
                Console.Write(" tuvo la nota mas alta con " + aux);
            }
        }
        static void Main(string[] args)
        {
            Escuela e = new Escuela();
            e.cargarAN();
            e.EstuA();
            e.EstuB();
            Console.ReadKey();
        }
    }
}
