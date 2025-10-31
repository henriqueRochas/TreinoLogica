//1118

using System.Globalization;

namespace TreinoLogico55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, media = 0;
            int x = 0;
            

            while (true)
            {
                int novoCalculo = 0;
                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notas >= 0 && notas <= 10)
                {
                    soma += notas;
                    x++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

                if (x == 2)
                {
                    media = soma / 2;
                    Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

                    while (novoCalculo != 1 && novoCalculo != 2 )
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao) ");
                        novoCalculo = int.Parse(Console.ReadLine());
                    }

                    if (novoCalculo == 1)
                    {
                        soma = 0;
                        x = 0;
                        continue;
                    }
                    else if (novoCalculo == 2)
                    {
                        break;
                    }   
                }
            }

        }
    }
}
