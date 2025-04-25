using System;

class Program
{
    static void Main() {
       float soma = 0;
       float numero = -1; // valor inicial diferente de 0 para entrar no while
       
       Console.WriteLine("Digite números para somar. Digite 0 para encerrar. ");
       
       while (numero != 0)
       {
           Console.Write("Digite um numero: ");
           numero = float.Parse(Console.ReadLine());
           
           soma = soma + numero;
       }
       Console.Write("\nA soma total é: "+ soma);
       Console.Write("\nFim do Programa");
    }
}