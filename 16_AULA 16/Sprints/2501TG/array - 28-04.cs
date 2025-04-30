using System;

class Program
{
    static void Main()
    {
     Console.WriteLine("Digite 10 números inteiros.");
        int[] total = new int[10];
        int soma = 0;

        for(int i=0; i < 10; i++)
        {
            Console.Write($"Digite o numero {i+1}: ");
            total[i] = int.Parse(Console.ReadLine());
            soma += total[i];
        }
        Console.WriteLine();
        Console.WriteLine($"A soma total é {soma}.");
        Console.WriteLine("\nOperação Matematica:");
        
        for(int i=0; i < 10; i++)
        {
            Console.WriteLine($"NUM{i+1} - {total[i]}");

        }
    }
}

}
