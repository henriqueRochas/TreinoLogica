using System.Globalization;

namespace TreinoLogica16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Acesso liberado. Boas Compras!");
        }
        else
        {
            Console.WriteLine("Acesso Negado. Idade minima não atingina");
        }
    }
}