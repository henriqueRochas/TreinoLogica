//1143

namespace TreinoLogico61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calcQuadrado = 0;
            int calcCubo = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                calcQuadrado = i * i;
                calcCubo = calcQuadrado * i;
                Console.WriteLine($"{i} { calcQuadrado} {calcCubo}");

            }
        }
    }
}
