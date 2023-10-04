using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) {

                for (int d = 0; d < numero * 2; d++) {

                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
