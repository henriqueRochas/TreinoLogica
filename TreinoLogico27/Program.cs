namespace TreinoLogico27
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int cont = 0;
            double media = 0.0;
            double soma = 0.0;

            for (int i = 1; i <= 5; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cont++;
                    soma += num;
                }
            }

            if (cont > 0)
            {
                media = soma / cont;
                Console.WriteLine($"{cont} valores positivos");
                Console.WriteLine($"{media.ToString("F1")}");
            }
        }         
    }             
}
