using System;

class Program
{
    static void Main()
    {
       // criação de lista "vazia"
       List<string> nomes = new List<string>();
       string nome = "";
       
       Console.WriteLine("Digite os nome. Para encerrar, digite 'sair'.  ");
       
      
       //estrutura while
       while (nome.ToLower != "sair")
       
       {
           Console.Write("Digite um nome: ");
           nome = Console.ReadLine();
           
           if (nome.ToLower() ! = "sair")
           {
               nomes.Add(nome);
           }
       }
       Console.WriteLine("\nNomes Cadastrados:");
       foreach (string n in nomes)
       {
           Console.WriteLine("-" + n);
       }
       Console.WriteLine("\nFim do programa");
       
    }
}

// to lower, string armazenar entradas
