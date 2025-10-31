// 1117

using System.Globalization;

namespace TreinoLogico54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int cont = 0;

            while (true)
            {    
                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notas >= 0.0 && notas <= 10.0)
                {
                    soma += notas;
                    cont++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

                if (cont == 2)
                {
                    break;
                }
            }

            double media = soma / 2;
            Console.WriteLine($"media = {media}",CultureInfo.InvariantCulture);
        }
    }
}
