using System;

class Program
{
    static void Main()
    {
        int contador = 10;
        
        Console.WriteLine("Contagem regressiva:");
        
        while (contador >= 1)
        {
            Console.WriteLine(contador); // Imprime o valor atual do contador
            contador--; // Decrementa o contador em 1
        }
        
        Console.WriteLine("FIM!");
    }
}
