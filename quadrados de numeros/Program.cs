using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrados_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            for(int i = 1; i<=10; i++)
            {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine(num + "² = " + Math.Pow(num, 2));
            }
            Console.ReadKey();
        }
    }
}

