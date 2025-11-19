//1153

using System.Runtime.InteropServices;

namespace TreinoLogico68
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int calc = 1;

            for (int i = 1; i <= n; i++)
            {
                calc = calc *  i;
            }

            Console.WriteLine(calc);
        }
    }
}
