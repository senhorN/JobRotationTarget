using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJobRotationTarget.SequenciaDeFibonacci
{
    internal class Fibonacci
    {
        public void funcaoFibonacci()
        {


            Console.WriteLine("Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.");
            Console.WriteLine
               ("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("[Sequência de fibonacci]");
            Console.WriteLine();

            Console.WriteLine("Digite um número inteiro para verificar se ele pertence à sequência de Fibonacci: ");
            int num = int.Parse(Console.ReadLine());

            //criação das variaveis a, b, c do tipo inteiro
            int a = 0;
            int b = 1;
            int c = 0;

            //enquanto C for maior que o numero que usuario colocou continua 
            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if (c == num)
            {
                Console.WriteLine(num + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(num + " não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }
    }
}
