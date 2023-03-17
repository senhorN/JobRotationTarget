using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChallengeJobRotationTarget.Distribuidora
{
    internal class faturamentoDistribuidora
    {
        //Classe ObjectJson criada pra pegar os atributos: Dia e valor 
        public class ObjectJson
        {
            public int dia { get; set; }
            public decimal valor { get; set; }

        }
        public void Faturamento()
        {
            //Json 
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "dados.json");

            string jsonString;

            using (StreamReader reader = new StreamReader(filePath))
            {

                jsonString = reader.ReadToEnd();
            }
            //Lista fat aonde será armazenado jsonString
            List<ObjectJson> fat = JsonConvert.DeserializeObject<List<ObjectJson>>(jsonString);


            Console.WriteLine("Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne: \n");
            Console.WriteLine(" > O menor valor de faturamento ocorrido em um dia do mês; \n ");
            Console.WriteLine(" > O maior valor de faturamento ocorrido em um dia do mês; \n");
            Console.WriteLine(" > Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            //pulo de uma linha 
            Console.WriteLine();

            #region valores do faturamento: MAIOR e MENOR

            //impressão do menor valor
            Console.WriteLine("Menor valor faturado no mês");

            //variavel aux
            decimal auxmin;

            for (int i = 0; i < fat.Count; i++)
            {
                for (int j = i + 1; j < fat.Count; j++)
                {
                    if (fat[i].valor > fat[j].valor)
                    {
                        //troca de elementos 
                        auxmin = fat[i].valor;
                        fat[i].valor = fat[j].valor;
                        fat[j].valor = auxmin;
                    }

                }

            }
            Console.WriteLine(fat[0].valor + "\n");


            //impressão do maior valor 
            Console.WriteLine("Maior valor faturado no mês");

            //variavel aux
            decimal aux;


            for (int i = 0; i < fat.Count; i++)
            {
                for (int j = i + 1; j < fat.Count; j++)
                {
                    if (fat[i].valor < fat[j].valor)
                    {
                        //troca de elementos 
                        aux = fat[i].valor;
                        fat[i].valor = fat[j].valor;
                        fat[j].valor = aux;
                    }

                }

            }
            Console.WriteLine(fat[0].valor + "\n");

            //separação dos numeros maior que 0

            int contador = 0;
            for (int i = 0; i < fat.Count; i++)
            {
                if (fat[i].valor > 0)
                {
                    contador++;
                }
            }

            decimal[] sep = new decimal[contador];

            for (int x = 0; x < fat.Count; x++)
            {
                if (fat[x].valor > 0)
                {
                    sep[x] = fat[x].valor;
                }
            }
            //desenvolvendo a media da nota
            decimal total = 0;

            for (int z = 0; z < contador; z++)
            {
                total = total + fat[z].valor;
            }

            total = total / contador;


            int contAux = 0;
            for (int i = 0; i < contador; i++)
            {
                if (sep[i] > total)
                {
                    contAux++;
                }
            }
            Console.WriteLine("dias no mês em que o valor de faturamento diário foi superior à média mensal \n");
            Console.WriteLine(contAux);
            #endregion



        }
    }
}
