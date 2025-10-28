namespace TreinoLogico37
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sequencia = new int[n];
            sequencia[0] = 1;

            if (n >= 2)
            {
                sequencia[1] = 1;
            }

            for (int i = 2; i < n; i++)
            {
                sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
            }
            for(int i = n - 1; i >= 0 ;i--)
            {
                Console.Write($"{sequencia[i]}  ");
            }
        }
    }
}