using System.Globalization;

namespace TreinoLogico46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;
            double percentualCoelho = 0.0;
            double percentualRatos = 0.0;
            double percentualSapos = 0.0;

            for (int i = 0; i < n; i++)
            {
                string quantia = Console.ReadLine();
                string[] v = quantia.Split(' ');
                int qtd = int.Parse(v[0]);

                totalCobaias += qtd;

                if (v[1].Contains("C"))
                {
                    totalCoelhos += qtd;
                }
                else if (v[1].Contains("R"))
                {
                    totalRatos += qtd;
                }
                else if (v[1].Contains("S"))
                {
                    totalSapos += qtd;
                }
            }

            percentualCoelho = ((double)totalCoelhos / totalCobaias) * 100;
            percentualRatos = ((double)totalRatos / totalCobaias) * 100;
            percentualSapos = ((double)totalSapos / totalCobaias) * 100;

            Console.WriteLine($"Total: {totalCobaias}");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelho.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Percentual de ratos: {percentualRatos.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Percentual de sapos: {percentualSapos.ToString("F2", CultureInfo.InvariantCulture)}%");
        }
    }
}

//10
//10 C
//6 R
//15 S
//5 C
//14 R
//9 C
//6 R
//8 S
//5 C
//14 R