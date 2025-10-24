using System.Globalization;

namespace TreinoLogico22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calcImposto = 0.00;
            double valorImposto = 0.00;
            if (salario > 4500.00)
            {
                calcImposto = calcImposto + ( 0.28 * (salario -  4500.00));
                salario = 4500.00;
            }
            if (salario > 3000.00)
            {
                calcImposto = calcImposto + (0.18 * (salario - 3000.00));
                salario = 3000.00;
            }
            if (salario > 2000.00)
            {
                calcImposto = calcImposto + (0.08 * (salario - 2000.00));
                salario = 2000.00;
            }

            valorImposto = calcImposto;

            if (calcImposto > 0)
            {
                Console.WriteLine($"R${valorImposto}");
            }
            else
            {
                Console.WriteLine("Isento");
            }
           
        }
    }
}