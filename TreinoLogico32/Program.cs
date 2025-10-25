using System;

namespace TreinoLogico32
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maiorNumero;
            int menorNumero;
            int somaImpares = 0;

            if(x > y)
            {  
                maiorNumero = x; 
                menorNumero = y;
            }
            else
            {
                maiorNumero = y;
                menorNumero = x;
            }

            for (int i = menorNumero + 1; i < maiorNumero; i++)
            {
                if (i %2 != 0)
                {
                    somaImpares += i;
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}
