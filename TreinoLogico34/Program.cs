namespace TreinoLogico34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int quadrado;
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    quadrado = i * i;
                    Console.WriteLine($"{i}^2 = {quadrado}");
                 }
            }
        }
    }
}
