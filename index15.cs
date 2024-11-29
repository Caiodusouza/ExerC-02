using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

        int resultado = numero;
        int potencia = 1; // Começa com 2^0

        Console.WriteLine($"Sequência de multiplicação de {numero} por potências de 2:");

        // Laço enquanto o resultado não ultrapassar 1000
        while (resultado <= 1000)
        {
            Console.WriteLine($"{numero} * 2^{potencia} = {resultado}");
            resultado = numero * (int)Math.Pow(2, potencia); // Multiplica o número pela potência de 2
            potencia++; 
        }

        Console.WriteLine("O resultado ultrapassou 1000!");
    }
}
