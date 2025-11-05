// 1146

namespace TreinoLogico64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                if(n == 0)
                {
                    break;
                }
            }
        }
    }
}
