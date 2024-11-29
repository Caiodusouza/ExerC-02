using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

            if (numero % 2 != 0) // Verifica se o número é ímpar
            {
                Console.WriteLine("O número é ímpar. Tente novamente.");
            }
        } while (numero % 2 != 0);

        Console.WriteLine("Parabéns! Você digitou um número par.");
    }
}
