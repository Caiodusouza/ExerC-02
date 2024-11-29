using System;

class Program
{
    static void Main()
    {
        int numeroSecreto = 42; // Define o número secreto
        int palpite;            // Variável para armazenar o palpite do usuário

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto.\n");

        do
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine()); 

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior. Tente novamente.\n");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor. Tente novamente.\n");
            }
        } while (palpite != numeroSecreto);

        Console.WriteLine("Parabéns! Você adivinhou o número secreto!");
    }
}
