using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJobRotationTarget.Invert
{
    internal class InversaoCaracter
    {
        public void invertCaracter()
        {
            string info;
            int letra;

            Console.WriteLine(" Escreva um programa que inverta os caracteres de um string. \r\n");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("[Inversão de caracter]");
            Console.WriteLine();

            Console.WriteLine("Informe uma palavra:");
            info = Convert.ToString(Console.ReadLine());

            letra = info.Length;

            char[] arr = new char[letra];

            for (int i = letra; i > letra; i--)
            {
                arr[i] = arr[i - letra];

            }
            Console.WriteLine(inverterString(info));

        }
        //método privado de inverter a palavra digitada do usuário
        private static string inverterString(string normal)
        {
            string inversa = normal;

            if (normal.Length > 1)
            {
                inversa = String.Empty;
                for (int i = normal.Length - 1; i >= 0; i--)
                {
                    inversa += normal[i];
                }
            }

            return inversa;

        }
    }
}
