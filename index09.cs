using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Contador de Vogais");
        Console.WriteLine("Digite uma frase para contar as vogais. Digite 'fim' para encerrar o programa.\n");

        string entrada;

        do
        {
            Console.Write("Digite uma string: ");
            entrada = Console.ReadLine().ToLower(); // Lê a entrada do usuário e converte para minúsculas

            if (entrada == "fim")
            {
                Console.WriteLine("Programa encerrado. Até mais!");
                break;
            }

            int contadorVogais = 0;

            // Itera sobre cada caractere da string e verifica se é uma vogal
            foreach (char c in entrada)
            {
                if ("aeiou".Contains(c)) 
                {
                    contadorVogais++;
                }
            }

            Console.WriteLine($"A string contém {contadorVogais} vogais.\n");

        } while (true); 
    }
}
