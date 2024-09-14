using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();  
            int opcao = LerOpcao();  
            switch (opcao)
            {
                case 1:
                    VerificarFibonacci();
                    break;
                case 2:
                    ContarLetraA();
                    break;
                case 3:
                    CalcularValorSoma();
                    break;
                case 4:
                    CompletarSequencias();
                    break;
                case 5:
                    ResolverInterruptores();
                    break;
                case 6:
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção de 1 a 6.");
                    break;
            }
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\nEscolha o desafio que deseja executar:");
        Console.WriteLine("1) Verificar se um número pertence à sequência de Fibonacci");
        Console.WriteLine("2) Verificar a existência da letra 'a' em uma string e sua contagem");
        Console.WriteLine("3) Calcular o valor final da variável SOMA no trecho de código");
        Console.WriteLine("4) Completar a lógica das sequências");
        Console.WriteLine("5) Resolver o problema dos interruptores e lâmpadas");
        Console.WriteLine("6) Sair");
        Console.Write("Digite a opção desejada (1-6): ");
    }

    static int LerOpcao()
    {
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 6)
        {
            Console.Write("Opção inválida. Digite um número de 1 a 6: ");
        }
        return opcao;
    }

    // Desafio 1: Verifica se um número pertence à sequência de Fibonacci
    static void VerificarFibonacci()
    {
        Console.WriteLine("\nDigite um número para verificar se ele pertence à sequência de Fibonacci:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine(PertenceFibonacci(numero)
                ? $"O número {numero} pertence à sequência de Fibonacci."
                : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }

    // Função que verifica se um número pertence à sequência de Fibonacci
    static bool PertenceFibonacci(int numero)
    {
        if (numero == 0 || numero == 1) return true;

        int a = 0, b = 1, proximoNumero = a + b;
        while (proximoNumero <= numero)
        {
            if (proximoNumero == numero) return true;
            a = b;
            b = proximoNumero;
            proximoNumero = a + b;
        }
        return false;
    }

    // Desafio 2: Verifica a existência da letra 'a' em uma string e conta as ocorrências
    static void ContarLetraA()
    {
        Console.WriteLine("\nDigite uma string para verificar a ocorrência da letra 'a':");
        string input = Console.ReadLine();
        int contador = 0;

        foreach (char c in input.ToLower())
        {
            if (c == 'a') contador++;
        }

        Console.WriteLine($"A letra 'a' ocorre {contador} vez(es) na string.");
    }

    // Desafio 3: Calcula o valor final da variável SOMA no trecho de código
    static void CalcularValorSoma()
    {
        int indice = 12, soma = 0;

        for (int k = 1; k <= indice; k++)
        {
            soma += k;
        }

        Console.WriteLine($"O valor final da variável SOMA é: {soma}");
    }

    // Desafio 4: Completa a lógica das sequências
    static void CompletarSequencias()
    {
        Console.WriteLine("\na) 1, 3, 5, 7, ___");
        Console.WriteLine("Resposta: 9 (sequência de números ímpares)");

        Console.WriteLine("\nb) 2, 4, 8, 16, 32, 64, ____");
        Console.WriteLine("Resposta: 128 (cada número é o dobro do anterior)");

        Console.WriteLine("\nc) 0, 1, 4, 9, 16, 25, 36, ____");
        Console.WriteLine("Resposta: 49 (sequência de quadrados perfeitos: 0², 1², 2², 3², ...)");

        Console.WriteLine("\nd) 4, 16, 36, 64, ____");
        Console.WriteLine("Resposta: 100 (sequência de quadrados perfeitos de números pares: 2², 4², 6², 8², ...)");

        Console.WriteLine("\ne) 1, 1, 2, 3, 5, 8, ____");
        Console.WriteLine("Resposta: 13 (sequência de Fibonacci)");

        Console.WriteLine("\nf) 2, 10, 12, 16, 17, 18, 19, ____");
        Console.WriteLine("Resposta: 200 (sequência de números começando com 'd' em inglês: two, ten, twelve, sixteen, seventeen, eighteen, nineteen, two hundred)");
    }

    // Desafio 5: Solução para o problema dos interruptores e lâmpadas
    static void ResolverInterruptores()
    {
        Console.WriteLine("\nSolução para o problema dos interruptores e lâmpadas:");
        Console.WriteLine("Primeiro ligo o primeiro interruptor e deixo ligado por alguns minutos.");
        Console.WriteLine("Segundo desligo o primeiro interruptor e ligo o segundo interruptor.");
        Console.WriteLine("Terceiro vou até a salas das lamapdas");
        Console.WriteLine(" A lâmpada que está acesa é controlada pelo segundo interruptor.");
        Console.WriteLine(" A lâmpada que está apagada, mas quente, é controlada pelo primeiro interruptor.");
        Console.WriteLine(" A lâmpada que está apagada e fria é controlada pelo terceiro interruptor.");
    }
}
