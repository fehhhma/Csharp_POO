using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Itens de Compra");
        
        Console.WriteLine("Digite quantos itens vc quer adicionar a lista de compras: ");
        string entrada = Console.ReadLine();
        
        int numero;
        
        Console.WriteLine("Digite qual será o nome de cada item: ");
        string entrada1 = Console.ReadLine();
        
        float itens;

        //Verifica se o valor digitando é um numero inteiro
        if (int.TryParse (entrada, out numero))
        {
            Console.WriteLine($"\nNumero de itens eh {numero}:");
        
            for (int i=1; i<1; i++)
            {
                int resultado = numero + i;
                Console.WriteLine($"{numero} + {i} = {itens} {resultado}:" );
            }
        }
        else
        {
            Console.WriteLine("Erro: Digite um numero de itens validos.");
        }
    Console.ReadLine();
    }
}
