using System; //Utilizando o 1 PROG

class Program // Identificação do PROG
{
    static void Main() // Resposta de Acordo
    {
        // Escrever na tela
        Console.Write("Media de 5 notas");
        
        // Declaração das Variaveis
        Console.Write("Digite o Primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Terceiro número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Quarto número: ");
        double numero4 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Quinto número: ");
        double numero5 = Convert.ToDouble(Console.ReadLine());
        
   
        
        //Operações matematicas
        double soma = numero1 + numero2 + numero3 + numero4 + numero5;
        double media = soma/5;
     
        
        // Exibição
        Console.WriteLine();
        Console.WriteLine("Resultado da Media das Notas");
        Console.WriteLine("O valor da Media é: " + media);
       
    }
}
