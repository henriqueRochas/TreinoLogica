namespace TreinoLogico29
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contPar = 0;
            int contImpar = 0;
            int contPositivo = 0;
            int contNegativo = 0;

            for (int i = 1; i <= 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                }
                else
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPositivo++;
                }
                else
                {
                    contNegativo++;
                }

            }
            Console.WriteLine($"{contPar} valores par(es)");
            Console.WriteLine($"{contImpar} valores impares(es)");
            Console.WriteLine($"{contPositivo} valores positivo(s)");
            Console.WriteLine($"{contNegativo} valores negativo(s)");
        }
    }
}
