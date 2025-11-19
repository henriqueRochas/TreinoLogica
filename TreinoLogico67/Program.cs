//1151

namespace TreinoLogico67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(a);

                if(i != n - 1)
                {
                    Console.Write(" ");
                }
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
