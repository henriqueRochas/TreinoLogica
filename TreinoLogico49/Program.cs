// 1101
namespace TreinoLogico49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorNum;
            int menorNum;
            bool parada = true;

            while (parada == true)
            {
                int soma = 0;
                string pares = Console.ReadLine();
                string[] mn = pares.Split(' ');
                int n = int.Parse(mn[0]);
                int m = int.Parse(mn[1]);

                if (n <= 0 || m <= 0)
                {
                    parada = false;
                    break;
                }

                if(n > m)
                {
                    maiorNum = n;
                    menorNum = m;
                }
                else
                {
                    maiorNum = m;
                    menorNum = n;
                }

                for(int j = menorNum; j <= maiorNum; j++)
                {
                    soma += j;
                    Console.Write($"{j} ");
                }

                Console.WriteLine($"Sum = { soma}");
            }

        }
    }
}
