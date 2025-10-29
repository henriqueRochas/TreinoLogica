namespace TreinoLogico38
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string xd;
            int x = 0;
            int d = 0;
            int calc = 0;

            for (int i = 0; i < n; i++)
            {
                int totalJoao = 0;
                int totalMaria = 0;

                for (int j = 0; j < 3; j++)
                {
                    xd = Console.ReadLine();
                    string[] pedacos = xd.Split(' ');
                    x = int.Parse(pedacos[0]);
                    d = int.Parse(pedacos[1]);
                    calc = x * d;
                    totalJoao = totalJoao + calc;
                }

                for (int m = 0; m < 3; m++)
                {
                    xd = Console.ReadLine();
                    string[] pedacos = xd.Split(' ');
                    x = int.Parse(pedacos[0]);
                    d = int.Parse(pedacos[1]);
                    calc = x * d;
                    totalMaria = totalMaria + calc;
                }

                if (totalJoao > totalMaria)
                {
                    Console.WriteLine("JOÃO");
                }
                else
                {
                    Console.WriteLine("MARIA");
                }
            }
        }
    }
}