//1182

using System.Globalization;

namespace TreinoLogico74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media;
            double[,] tabela = new double[12, 12];
            int coluna = int.Parse(Console.ReadLine());
            string operacao = Console.ReadLine();

            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    double valorColuna = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    tabela[i, j] = valorColuna;
                }
            }

            if(operacao == "S")
            {
                for(int d = 0;d < 12; d++)
                {
                    soma += tabela[d, coluna];
                }

                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if (operacao == "M") 
            {
                for (int d = 0; d < 12; d++)
                {
                    soma += tabela[d, coluna];
                }

                media = soma / 12;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
