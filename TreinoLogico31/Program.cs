namespace TreinoLogico31
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num++;
            }
            else
            {
                num = num;
            }

            for(int i = 1; i <= 6; i++)
            {
                Console.WriteLine(num);
                num += 2;
            }
        }
    }
}
