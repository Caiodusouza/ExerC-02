using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de Número Primo");
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário

        if (numero < 2)
        {
            Console.WriteLine($"{numero} não é primo (números menores que 2 não são primos).");
        }
        else
        {
            bool ehPrimo = true; // Supondo que o número seja primo inicialmente
            int divisor = 2;  

            while (divisor <= Math.Sqrt(numero))
            {
                if (numero % divisor == 0)
                {
                    ehPrimo = false; // Se houver um divisor, o número não é primo
                    break;
                }
                divisor++;
            }

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é primo.");
            }
        }
    }
}
