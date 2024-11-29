using System;

class Program
{
    static void Main()
    {
        int numero;
        bool numeroValido = false;

        Console.WriteLine("Digite um número entre 1 e 100.");

        while (!numeroValido)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

            if (numero >= 1 && numero <= 100)
            {
                numeroValido = true; // Número válido, sai do laço
                Console.WriteLine($"Você digitou um número válido: {numero}");
            }
            else
            {
                Console.WriteLine("Número inválido! Tente novamente. O número deve estar entre 1 e 100.");
            }
        }
    }
}
