using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_maiores_que_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, num, i;

            for (i = 1; i <= 30; i++)
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
                if (num>30)
                {
                    cont++;
                }
            }

            Console.Write("qtd. de números maiores que 30: ");
            Console.ReadLine();
        }
    }
}
