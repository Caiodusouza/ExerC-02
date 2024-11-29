using System;

class Program
{
    static void Main()
    {
        int numero;        // Variável para armazenar o número digitado pelo usuário
        int soma = 0;      // Variável para acumular a soma dos números

        Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");

        do
        {
            numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário
            soma += numero;                         // Adiciona o número à soma
        } while (numero != 0);                      // Continua até que o número seja 0

        Console.WriteLine($"A soma dos números digitados é: {soma}");
    }
}
