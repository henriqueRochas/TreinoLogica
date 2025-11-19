//1155

namespace TreinoLogico70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            for (int i = 1; i <= 100; i++)
            {
                 s = s + (1.00 / i);
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
