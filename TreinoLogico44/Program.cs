using System.Globalization;

namespace TreinoLogico44
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] peso = [2.0, 3.0, 5.0];
          
            double n1 = 0.00;
            double n2 = 0.00;
            double n3 = 0.00;

            double pesos = peso[0] + peso[1] + peso[2];

            for (int i = 0; i < n; i++)
            {
                string notas = Console.ReadLine();
                string[] notasSeparadas = notas.Split(' ');
                n1 = double.Parse(notasSeparadas[0], CultureInfo.InvariantCulture) * peso[0];
                n2 = double.Parse(notasSeparadas[1], CultureInfo.InvariantCulture) * peso[1];
                n3 = double.Parse(notasSeparadas[2], CultureInfo.InvariantCulture) * peso[2];

                double media = (n1 + n2 + n3) / pesos;

                Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);
            }

        }
    }
}