// 1144

namespace TreinoLogico62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int calc1 = i * i ;
                int calc2 = i * i * i;
                Console.WriteLine($"{i} {calc1} {calc2}");
                Console.WriteLine($"{i} {calc1 + 1} {calc2 + 1}");

            }
        }
    }
}
