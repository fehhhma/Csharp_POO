using System;

class Program
{
    static void Main()
    {
     Console.WriteLine("Digite 10 notas para calcular a media.");
        float[] notas = new float[10];
        float soma = 0, media;
        int notaMaior = 0;

        for(int i=0; i < 10; i++)
        {
            Console.Write($"Digite o numero da nota {i+1}: ");
            notas[i] = int.Parse(Console.ReadLine());
            soma += notas[i];
        }
        Console.WriteLine();
        media = soma/10;
        Console.WriteLine($"A media total das notas é {media}.");
        Console.WriteLine("\nNotas acima da média:");
        foreach (float nota in notas)
        {
            if (nota > media)
            {
                Console.WriteLine($"\nNota: {nota}");
                notaMaior++;
            }
        }
        
        Console.WriteLine("\nTotal de notas acima da media: {notaMaior}");
        
        
    }
}

  