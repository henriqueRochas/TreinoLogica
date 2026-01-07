//1156

namespace TreinoLogico71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double inferior = 1.00;
            for (int i = 1; i <= 39; i+=2)
            {
                s = s + (i / inferior);
                inferior *= 2;
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
