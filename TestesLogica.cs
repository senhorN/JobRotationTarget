using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int indice = 13; 
        int soma = 0;
        int k = 0;
        
        while(k < indice){
            k = k + 1;
            soma = soma + k;
        }
        Console.WriteLine("O resutado: " + soma);
    }
}
