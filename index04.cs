using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver sua tabuada: ");
        int numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário
        
        Console.WriteLine($"\nTabuada de {numero}:");
        
        int multiplicador = 1; // Inicializa o multiplicador com 1
        
        while (multiplicador <= 10) // Continua até o multiplicador ser 10
        {
            int resultado = numero * multiplicador;
            Console.WriteLine($"{numero} x {multiplicador} = {resultado}"); 
            multiplicador++;
        }
    }
}
