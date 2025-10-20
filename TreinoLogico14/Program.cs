using System.Globalization;

namespace TreinoLogico14;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("C: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            double perimetro = a + b + c;
            Console.WriteLine($"Perimetro: {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            double area = (a + b) * c / 2;
            Console.WriteLine($"Área: {area.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}