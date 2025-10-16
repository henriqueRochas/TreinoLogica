using System.Globalization;


namespace TreinoLogica01;

class Program
{
    static void Main(string[] args)
    {
        int[] peso = [2, 3, 4, 1];
        double nota = 0.00;
        double somadorNotas = 0.00;

        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"Digite a {i + 1}ª nota: ");
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            somadorNotas = somadorNotas + (nota * peso[i]);
        }

        double media = somadorNotas/ 10;
        Console.WriteLine($"Media: {media.ToString("F1")}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno Aprovado");
        }
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.Write("Aluno em exame: ");
            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double mediaFinal = (media + notaExame) / 2;

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
        else
        {
            Console.WriteLine("Aluno Reprovado");
        }
    }
}