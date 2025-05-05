using System;

class Program
{
    static void Main() {
        string [] nomes = new string [3];
        float[] nota1 = new float [3];
        float [] nota2 = new float [3];
        float [] media = new float [3];
        
        Console.WriteLine("Cadastro de 3 alunos\n");
        
        //entrada
        for (int i = 0; i<3; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}:");
            nomes[i] = Console.ReadLine();
            
            Console.Write($"Digite a 1° nota do aluno {nomes[i]}:");
            nota1[i] = float.Parse (Console.ReadLine());
            
            Console.Write($"Digite a 2° nota do aluno {nomes[i]}:");
            nota2[i] = float.Parse (Console.ReadLine());
            
            media[i] = CalcularMedia(nota1[i], nota2[i]);
            Console.WriteLine();
        }

     //exibir
     
          Console.WriteLine("Resultado Final:\n");
          for (int i = 0; i<3; i++)
          {
            Console.WriteLine($"Aluno: {nomes[i]}");
            Console.WriteLine($"Média: {media[i]:F2}");
            Console.WriteLine($"Situação: {VerificarSituacao(media[i])}");
            Console.WriteLine();
        }
    }


// função para calcular media

static float CalcularMedia(float n1, float n2) // parametros
{
    return (n1 + n2) / 2;
}

static string VerificarSituacao (float media)
{
    if (media >= 6.0f)
        return "Aprovado";
    
    else if (media >= 4.0f)
        return "Recuperação";
    
    else
        return "Reprovado";
    
    }
}
