namespace TreinoLogico40
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int somaGarrafas = e + f;
            int compraGarrafas1 = 0;
            int totalBebidos = 0;
            int compraGarrafas2 = 0;
            while(somaGarrafas >= c)
            {
                compraGarrafas1 = somaGarrafas / c;
                totalBebidos+= compraGarrafas1;
                compraGarrafas2 = somaGarrafas % c;
                somaGarrafas = compraGarrafas2 + compraGarrafas1;
            }
            Console.WriteLine(totalBebidos);
        }
    }
}