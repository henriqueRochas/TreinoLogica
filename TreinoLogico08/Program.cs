using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace TreinoLogica02
{

//Bhaskara

    class TreinoLogico02
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de A : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C : ");
            double c = double.Parse(Console.ReadLine());


            double delta = (b * b) - 4 * a * c;
            Console.WriteLine("Valor do delta " + delta.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            double bhaskaraMenos = (b - Math.Sqrt(delta)) / (2 * a);
            double bhaskaraMais = (b + Math.Sqrt(delta)) / (2 * a);

            if (delta <= 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 " + bhaskaraMenos.ToString("N5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 " + bhaskaraMais.ToString("N5", CultureInfo.InvariantCulture));
                
            }

        }

    }
}
