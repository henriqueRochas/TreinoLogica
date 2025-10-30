//1099

namespace TreinoLogico48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorNumero = 0;
            int menorNumero = 0;

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int somaImpares = 0;
                string valores = Console.ReadLine();

                string[] yx = valores.Split(' ');

                int x = int.Parse(yx[0]);
                int y = int.Parse(yx[1]);

                if (x > y)
                {
                    maiorNumero = x;
                    menorNumero = y;
                }
                else
                {
                    maiorNumero = y;
                    menorNumero = x;
                }

                for (int j = menorNumero + 1; j < maiorNumero; j++)
                {
                    if (j % 2 != 0)
                    {
                        somaImpares += j;
                        Console.WriteLine(somaImpares);
                    }

                }
            }
        }
    }
}
