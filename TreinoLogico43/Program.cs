namespace TreinoLogico43
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tabuada = 0;

            for(int i = 1; i <= 10; i++) 
            {
                tabuada = i * n;
                Console.WriteLine($"{i} x {n} = {tabuada}");
            }
        }
    }
}