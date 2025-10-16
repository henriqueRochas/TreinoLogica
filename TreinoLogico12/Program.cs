namespace TreinoLogica02
{
    class TreinoLogico02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0.00 && y == 0.00)
            {
                Console.WriteLine("Origem");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0  && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
