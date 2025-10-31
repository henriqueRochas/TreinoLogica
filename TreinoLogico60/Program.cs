// 1142

namespace TreinoLogico60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    cont++;

                    if (cont % 4 == 0)
                    {
                        cont++;
                    }                    
                    Console.Write($" {cont} ");
                }

                Console.WriteLine("PUM");
            }
        }
    }
}
