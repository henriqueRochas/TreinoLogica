
namespace TreinoLogico13;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0 && num <= 25)
        {
            Console.WriteLine($"O valor {num} está contido no intervalo entre 0 e 25");
        }
        else if (num > 25 && num <= 50)
        {
            Console.WriteLine($"O valor {num} está contido no intervalo entre 25 e 50;");
        }
        else if (num > 50 && num <= 75)
        {
            Console.WriteLine($"O valor {num} está contido no intervalo entre 50 e 75");
        }
        else if (num > 75 && num <= 100)
        {
            Console.WriteLine($"O valor {num} está contido no intervalor entre 75 e 100");
        }
        else
        {
            Console.WriteLine("Fora do intervalo");
        }
    }
}