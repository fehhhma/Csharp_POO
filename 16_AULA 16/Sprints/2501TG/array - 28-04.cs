using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        Console.WriteLine("\nNúmeros Digitados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros[i]);
        }
 
         
        Console.Write("\nValor total dos números somados: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros);
        }
        
        Console.WriteLine($"\nA soma dos números é: {soma}");
    }
}