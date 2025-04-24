using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Numero multiplo de 3 entre 1 e 50");
        
        Console.WriteLine("Digite um número: ");
        string entrada = Console.ReadLine();
        
        int numero;
        
        //Verifica se o valor digitando é um numero inteiro
        if (int.TryParse (entrada, out numero))
        {
            Console.WriteLine($"\nNumero Multiplo de 3 eh {numero}:");
        
            for (int i=3; i>=50; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}:" );
            }
        }
        else
        {
            Console.WriteLine("Erro: Digite um numero inteiro valido.");
        }
    Console.ReadLine();
    }
}
