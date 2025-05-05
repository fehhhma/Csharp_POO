using System;

class Program
{
    static void Main() {
        string [] nomes = new string [5];
        float[] produto1 = new float [5];
        float[] produto2 = new float [5];
        float[] produto3 = new float [5];
        float[] produto4 = new float [5];
        float[] produto5 = new float [5];
        float[] total = new float [5];
        
        Console.WriteLine("Produtos para compra\n");
        
        //entrada
        for (int i = 0; i<=5; i++)
        {
            Console.Write($"Digite o nome do produto: {i + 1}:");
            nomes[i] = Console.ReadLine();
            
            Console.Write($"Digite o valor do 1° produto {nomes[i]}:");
            produto1[i] = float.Parse (Console.ReadLine());
            
            Console.Write($"Digite o valor do 2° produto {nomes[i]}:");
            produto2[i] = float.Parse (Console.ReadLine());
            
            Console.Write($"Digite o valor do 3° produto {nomes[i]}:");
            produto3[i] = float.Parse (Console.ReadLine());
            
            Console.Write($"Digite o valor do 4° produto {nomes[i]}:");
            produto4[i] = float.Parse (Console.ReadLine());
            
            Console.Write($"Digite o valor do 5° produto {nomes[i]}:");
            produto5[i] = float.Parse (Console.ReadLine());
            
            total[i] = SomaTotal(produto1[i], produto2[i], produto3[i], produto4[i], produto5[i]);
            Console.WriteLine();
        }
        
        Console.WriteLine("Soma total:\n");
        

// função para somar os produtos

static float SomaTotal (float n1, float n2, float n3, float n4, float n5) // parametros
{
    return (n1 + n2 + n3 + n4 + n5);
}

    
    }
}
