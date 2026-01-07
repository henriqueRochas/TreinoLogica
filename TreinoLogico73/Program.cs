//1158

namespace TreinoLogico73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] xy = Console.ReadLine().Split();
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);


            for (int i = 0; i < n; i++)
            {
                if (x % 2 != 0)
                {
                    for (int j = x; j > y; j++)
                    {

                        j = x + y;
                        Console.WriteLine(j);
                    }

                }
            }
        }
    }
}
