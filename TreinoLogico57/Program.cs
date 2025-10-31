// 1132

namespace TreinoLogico57
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maiorNum = 0;
            int menorNum = 0;

            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int cont = 0;
            if(y > x)
            {
                maiorNum = y;
                menorNum = x;
            }
            else
            {
                maiorNum = x;
                menorNum = y;
            }

            for(int i = menorNum; i <= maiorNum; i++)
            {
                if (i % 13 != 0)
                {
                    cont += i;
                }
            }
            Console.WriteLine(cont);

            
            
        }
    }
}
