using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunoti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int soma;
            int subtracao;
            int multiplicacao;
            int divisao;
            int resto;
            //Console.Write("hello world");
            Console.Write("digite o 1°numero:");
            a = int.Parse(Console.ReadLine());

            Console.Write("digite o 2°numero:");
            b = int.Parse(Console.ReadLine());

            soma = a + b;
            Console.WriteLine("a soma dos valores:" + soma);

            subtracao = a - b;
           Console.WriteLine("a subtracao dos valores:" + subtracao);

            multiplicacao = a * b;
            Console.WriteLine("a multiplicacao dos valores:" + multiplicacao);

            divisao = a / b;
            Console.WriteLine("a divisao dos valores:" + divisao);


            Console.ReadKey();

            








        }
    }
}
