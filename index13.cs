using System;

class Program
{
    static void Main()
    {
        int numero;
        int pares = 0, impares = 0;

        Console.WriteLine("Contador de Números Pares e Ímpares");
        Console.WriteLine("Digite números inteiros. O programa irá parar quando você digitar 0.\n");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

            if (numero != 0) // Não conta o 0
            {
                if (numero % 2 == 0) // Verifica se o número é par
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

        } while (numero != 0); 

        Console.WriteLine($"\nTotal de números pares: {pares}");
        Console.WriteLine($"Total de números ímpares: {impares}");
    }
}
