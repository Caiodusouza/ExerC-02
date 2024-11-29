using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

        int contador = 0;  
        int numeroAbsoluto = Math.Abs(numero); // Considera o valor absoluto para lidar com números negativos

        if (numeroAbsoluto == 0)
        {
            contador = 1; 
        }
        else
        {
            while (numeroAbsoluto > 0)
            {
                numeroAbsoluto /= 10;  // Remove o último dígito do número
                contador++;      
            }
        }

        Console.WriteLine($"O número {numero} possui {contador} dígito(s).");
    }
}
