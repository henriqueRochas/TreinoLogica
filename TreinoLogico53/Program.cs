// 1116

using System.Globalization;

namespace TreinoLogico53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double div;
            double[] yx;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                yx = Console.ReadLine().Split().Select(double.Parse).ToArray();

                if (yx[1] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    div = yx[0] / yx[1];
                    Console.WriteLine(div.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
