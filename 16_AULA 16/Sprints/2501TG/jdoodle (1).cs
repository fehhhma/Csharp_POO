using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tabuada Simples");
        
        Console.WriteLine("Digite um número inteiro para ver a tabuada: ");
        string entrada = Console.ReadLine();
        
        int numero;
        
        //Verifica se o valor digitando é um numero inteiro
        if (int.TryParse (entrada, out numero))
        {
            Console.WriteLine($"\nTabuada do {numero}:");
        
            for (int i=1; i<10; i= ++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
    else
    {
        Console.WriteLine("Erro: Digite um numero inteiro valido.")
    }
    Console.ReadLine();
    }
}