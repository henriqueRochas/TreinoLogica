//1154

using System.Globalization;

namespace TreinoLogico69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            double calc = 0;
            double media = 0;
            while (true)
            {
                int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n < 0)
                {
                    break;
                }

                calc = calc + n;
                cont++;
            }
            media = calc / cont;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
