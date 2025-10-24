namespace TreinoLogico30
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
