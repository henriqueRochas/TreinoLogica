namespace TreinoLogico45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maiorValor = 0;
            int posicaoValor = 0;

           for (int i = 1; i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());

                if( n > maiorValor)
                {
                    maiorValor = n;
                    posicaoValor = i;
                }
            }
           Console.WriteLine(maiorValor);
           Console.WriteLine(posicaoValor);
        }
    }
}