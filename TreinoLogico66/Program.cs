// 1150

namespace TreinoLogico66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = 0;
            int cont = 0;
            int soma = 0;

            while ( z <= x)
            {
                 z = int.Parse(Console.ReadLine());
            }

            for (int i = x; i < z; i++)
            {
                soma += i;
                cont++;

                if(soma > z)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(cont);



        }
    }
}
