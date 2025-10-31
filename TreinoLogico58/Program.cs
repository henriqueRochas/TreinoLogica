// 1133

namespace TreinoLogico58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMaior = 0;
            int numMenor = 0;
            int cont = 0;

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                numMaior = x;
                numMenor = y;
            }
            else
            {
                numMaior = y;
                numMenor = x;
            }

            for(int i = numMenor; i <= numMaior; i++)
            {
                if(i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
