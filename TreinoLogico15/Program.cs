using System.Globalization;

namespace TreinoLogico15;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("São Multiplos!");
        }
        else
        {
          Console.WriteLine("Não são Multiplos!");
        }
    }
}