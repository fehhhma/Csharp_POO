using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int pista de corrida = 40;
        char[] tela = new char[largura];

        int corredorA = 0;              
        int corredorB = 0;    

        for (int i = 0; i < largura / 2; i++)
        {
            // Limpa a tela anterior
            for (int j = 0; j < largura; j++)
                tela[j] = ' ';

            if (corredorA == corredorA)
            {
                tela[corredorA] = '|'; // Colisão
            }
            else
            {
                tela[corredorA] = '|';
                tela[corredorB] = '|';
            }

            Console.WriteLine(new string(tela));
            Thread.Sleep(150);

            corredorA++;
            corredorB--;
        }

        Console.WriteLine("\nO vencendor foi: ");
    }
}