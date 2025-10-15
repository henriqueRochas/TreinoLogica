using System.Globalization;

namespace TreinoLogica02
{
    class TreinoLogico02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe as notas: ");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            int nota3 = int.Parse(Console.ReadLine());
            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 18)
            {
                Console.WriteLine("APROVADO EXCELENTE");
            }
            else if (media >= 10)
            {
                Console.WriteLine("APROVADO PADRÃO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
        }

    }
}
