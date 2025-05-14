using System;

class Program
{
    static void Main()
    {
        // Variáveis principais
        float valor;
        string unidadeOrigem;
        bool continuar = true;

        // Loop principal
        while (continuar)
        {
            // Entrada do valor
            Console.WriteLine("Digite o valor a ser convertido (ex.: 150.5):");
            string entradaValor = Console.ReadLine();

            // Validação do valor
            if (!float.TryParse(entradaValor, out valor) || valor < 0)
            {
                Console.WriteLine("Valor inválido! Digite um número positivo.");
                continue;
            }

            // Entrada da unidade
            Console.WriteLine("Digite a unidade de origem (m para metros, cm para centímetros, km para quilometros, mm para milimetro):");
            unidadeOrigem = Console.ReadLine().ToLower();

            // Processamento e conversão
            if (unidadeOrigem == "cm")
            {
                float valorConvertido = valor / 100;
                Console.WriteLine($"{valor} cm = {valorConvertido} m");
            }
            else if (unidadeOrigem == "m")
            {
                float valorConvertido = valor * 100;
                Console.WriteLine($"{valor} m = {valorConvertido} cm");
            }
            
             else if (unidadeOrigem == "km")
            {
                float valorConvertido = valor / 100;
                Console.WriteLine($"{valor} m = {valorConvertido} km");
            }
            
             else if (unidadeOrigem == "mm")
            {
                float valorConvertido = valor * 100;
                Console.WriteLine($"{valor} cm = {valorConvertido} mm");
            }
            else
            {
                Console.WriteLine("Unidade inválida! Use 'm', 'cm', 'km' ou 'mm'.");
                continue;
            }

            // Continuar ou sair
            Console.WriteLine("Deseja fazer outra conversão? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            if (resposta != "s")
            {
                continuar = false;
                Console.WriteLine("Programa encerrado.");
            }
        }
    }
}
