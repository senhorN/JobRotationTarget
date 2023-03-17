using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJobRotationTarget.PercentualD
{
    internal class CalculoPercentual
    {
        public void Percentual()
        {
            //Variavel do tipo float pra armazenar os nomes dos estados 
            float SP, RJ, MG, ES, OUTROS;

            // valor de cada estado 
            SP = 67836.43f;
            RJ = 36678.66f;
            MG = 29229.88f;
            ES = 27165.48f;
            OUTROS = 19849.53f;

            float total;

            total = SP + RJ + MG + ES + OUTROS;

            #region Porcentual
            SP = (SP / total) * 100;
            RJ = (RJ / total) * 100;
            MG = (MG / total) * 100;
            ES = (ES / total) * 100;
            OUTROS = (OUTROS / total) * 100;
            #endregion 
            Console.WriteLine("[Percentual de cada estado] \n");


            Console.WriteLine("\n Estado de São paulo: " + SP + "%" +
            "\n Estado do Rio de Janeiro: " + RJ + "%" +
            "\n Estado de Minas Gerais: " + MG + "%" +
            "\n Estado de Espirito Santo: " + ES + "%" +
            "\n Outros estados: " + OUTROS + "%");



        }
    }
}
