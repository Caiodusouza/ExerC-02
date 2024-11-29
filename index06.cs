using System;

class Program
{
    static void Main()
    {
        string operacao; // Variável para armazenar a operação escolhida pelo usuário

        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("Digite '+' para soma, '-' para subtração, '*' para multiplicação, '/' para divisão.");
        Console.WriteLine("Digite 'sair' para encerrar o programa.\n");

        do
        {
            Console.Write("Escolha uma operação (+, -, *, /) ou 'sair': ");
            operacao = Console.ReadLine().ToLower(); // Lê a operação e converte para minúsculas

            if (operacao == "sair")
            {
                Console.WriteLine("Encerrando a calculadora. Até mais!");
                break;
            }

            // Valida se a operação é válida
            if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {
                Console.WriteLine("Operação inválida. Tente novamente.");
                continue;
            }

            // Solicita os números para a operação
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // Calcula o resultado com base na operação escolhida
            double resultado = 0;
            bool divisaoValida = true;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        divisaoValida = false;
                    }
                    break;
            }

            if (divisaoValida)
            {
                Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}\n");
            }

        } while (true);
    }
}
