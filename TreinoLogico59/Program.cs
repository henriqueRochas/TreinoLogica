//1134

namespace TreinoLogico59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;

           
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                   case 1:
                        contAlcool++;
                        break;
                   case 2:
                        contGasolina++;
                        break;
                    case 3: 
                        contDiesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine($"Alcool: {contAlcool}");
                        Console.WriteLine($"Gasolina: {contGasolina}");
                        Console.WriteLine($"Diesel: {contDiesel}");
                        break;
                }

                if(n == 4)
                {
                    break;
                }
            }
        }
    }
}
