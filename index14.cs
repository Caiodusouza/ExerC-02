using System;

class Program
{
    static void Main()
    {
        int numero;
        int somaPares = 0;

        Console.WriteLine("Soma dos Números Pares");
        Console.WriteLine("Digite números inteiros. O programa irá somar apenas os números pares e parar quando você digitar 0.\n");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

            if (numero % 2 == 0 && numero != 0) // Verifica se o número é par e diferente de 0
            {
                somaPares += numero; 
            }

        } while (numero != 0);

        Console.WriteLine($"\nA soma dos números pares digitados é: {somaPares}");
    }
}
