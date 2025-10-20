using System.Globalization;

namespace TreinoLogico13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade desejada: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco = 0.00;
        double soma;

        switch (codigo)
        {
            case 1:
                Console.WriteLine("Cachorro Quente");
                preco = 4.00;
                break;
            case 2:
                Console.WriteLine("X-Salada");
                preco = 4.50;
                break;
            case 3:
                Console.WriteLine("X-Bacon");
                preco = 5.00;
                break;
            case 4:
                Console.WriteLine("Torrada Simples");
                preco = 2.00;
                break;
            case 5:
                Console.WriteLine("Refrigerante");
                preco = 1.50;
                break;
            default:
                Console.WriteLine("Opção invalida, tente novamente!");
                break;
        };

        if (preco > 0.00)
        {
            soma = quantidade * preco;
            Console.WriteLine($"Total: R${soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}