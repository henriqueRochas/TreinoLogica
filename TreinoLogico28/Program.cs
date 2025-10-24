namespace TreinoLogico28
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 0;

            for (int i = 1; i <= 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num %2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores pares");
        }
    }
}
