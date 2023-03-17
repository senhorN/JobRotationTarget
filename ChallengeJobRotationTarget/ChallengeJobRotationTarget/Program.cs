// See https://aka.ms/new-console-template for more information

//variaveis
int number = 0;
string res;


//instanciando as classes
ChallengeJobRotationTarget.SequenciaDeFibonacci.Fibonacci fibo = new ChallengeJobRotationTarget.SequenciaDeFibonacci.Fibonacci();

ChallengeJobRotationTarget.Distribuidora.faturamentoDistribuidora fat = new ChallengeJobRotationTarget.Distribuidora.faturamentoDistribuidora();

ChallengeJobRotationTarget.PercentualD.CalculoPercentual perc = new ChallengeJobRotationTarget.PercentualD.CalculoPercentual();

ChallengeJobRotationTarget.Invert.InversaoCaracter inver = new ChallengeJobRotationTarget.Invert.InversaoCaracter();

Console.WriteLine("---------------------------------------------------------------------------------------------");

Console.WriteLine("Bem vindo ao desafio JobRotationTarget\n");
Console.WriteLine("Os números abaixo sobre qual sistema você deseja inicialzar.");

Console.WriteLine();//pulo de uma linha 

Console.WriteLine("1 - Sequência de Fibonacci");
Console.WriteLine("2 - Faturamento de distribuidora");
Console.WriteLine("3 - Percentual de uma Distribuidora ");
Console.WriteLine("4 - Inversão de caracter");

Console.WriteLine("---------------------------------------------------------------------------------------------");
Console.WriteLine();//pulo de uma linha 


Console.WriteLine("Informe um número:");
number = Convert.ToInt32(Console.ReadLine());


switch (number)
{
    case 1:
        Console.Clear();//limpatela 
        Console.WriteLine("Você escolheu a sequência de Fibonacci \n");
        Console.WriteLine();

        //let
        fibo.funcaoFibonacci();

        break;
    case 2:
        Console.Clear();
        Console.WriteLine("Você escolheu o faturamento diario de uma empresa. \n");
        Console.WriteLine();

        //let
        fat.Faturamento();

        break;
    case 3:
        Console.Clear();
        Console.WriteLine("Você escolheu o Percentual de uma distribuidora. \n");
        Console.WriteLine();

        //let
        perc.Percentual();
        break;
    case 4:
        Console.Clear();
        Console.WriteLine("Você escolheu a inversão de caracteres");
        Console.WriteLine();

        //let
        inver.invertCaracter();

        break;

    default:
        Console.WriteLine("O número que você digitou não existe.");
        break;           
}

