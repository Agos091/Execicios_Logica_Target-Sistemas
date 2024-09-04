using System;
using Newtonsoft.Json.Linq;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecione a questão que deseja executar:");
            Console.WriteLine("1. Cálculo de SOMA");
            Console.WriteLine("2. Verificar número na sequência de Fibonacci");
            Console.WriteLine("3. Cálculo de faturamento diário");
            Console.WriteLine("4. Cálculo de percentual de faturamento por estado");
            Console.WriteLine("5. Inverter string");
            Console.WriteLine("6. Sair");
            Console.Write("Digite a opção (1-6): ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Questao1();
                    break;
                case "2":
                    Questao2();
                    break;
                case "3":
                    Questao3();
                    break;
                case "4":
                    Questao4();
                    break;
                case "5":
                    Questao5();
                    break;
                case "6":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // Questão 1: Cálculo do valor final da variável SOMA
    static void Questao1()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"O valor final de SOMA é: {SOMA}");
    }

    // Questão 2: Verificação de número na sequência de Fibonacci
    static void Questao2()
    {
        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int num = int.Parse(Console.ReadLine());

        bool isFibonacci = IsInFibonacci(num);

        if (isFibonacci)
        {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }

    static bool IsInFibonacci(int number)
    {
        int a = 0, b = 1, c = 0;

        while (c < number)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == number || number == 0;
    }

    // Questão 3: Cálculo de faturamento diário com input de JSON (exemplo simplificado)
    static void Questao3()
    {
        Console.WriteLine("Informe o faturamento diário em formato JSON:");
        string jsonFaturamento = Console.ReadLine();

        var faturamento = Newtonsoft.Json.Linq.JArray.Parse(jsonFaturamento)
            .Where(x => (double)x["valor"] > 0)
            .Select(x => (double)x["valor"]);

        double menorValor = faturamento.Min();
        double maiorValor = faturamento.Max();
        double mediaMensal = faturamento.Average();

        int diasAcimaMedia = faturamento.Count(x => x > mediaMensal);

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Maior valor: {maiorValor}");
        Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
    }

    // Questão 4: Cálculo de percentual de faturamento por estado
    static void Questao4()
    {
        Console.WriteLine("Informe o faturamento de SP:");
        double sp = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o faturamento de RJ:");
        double rj = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o faturamento de MG:");
        double mg = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o faturamento de ES:");
        double es = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o faturamento de Outros:");
        double outros = double.Parse(Console.ReadLine());

        double total = sp + rj + mg + es + outros;

        Console.WriteLine($"SP: {((sp / total) * 100):F2}%");
        Console.WriteLine($"RJ: {((rj / total) * 100):F2}%");
        Console.WriteLine($"MG: {((mg / total) * 100):F2}%");
        Console.WriteLine($"ES: {((es / total) * 100):F2}%");
        Console.WriteLine($"Outros: {((outros / total) * 100):F2}%");
    }

    // Questão 5: Inversão de uma string
    static void Questao5()
    {
        Console.WriteLine("Informe uma string para inverter:");
        string input = Console.ReadLine();
        char[] inverted = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            inverted[i] = input[input.Length - 1 - i];
        }

        string invertedString = new string(inverted);
        Console.WriteLine($"String invertida: {invertedString}");
    }
}
