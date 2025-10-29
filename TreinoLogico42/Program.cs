using System.ComponentModel;
using System.Reflection.Metadata;

namespace TreinoLogico42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            string[] corteDeA = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(corteDeA[i]);
            }

            for (int i = 0; i < q; ++i)
            {
                string[] consulta = Console.ReadLine().Split(' ');

                if (consulta[0] == "1")
                {
                    int A = int.Parse(consulta[1]);
                    int B = int.Parse(consulta[2]);
                    int V = int.Parse(consulta[3]);

                    A--;
                    B--;

                    for (int j = A; j <= B; j++)
                    {
                        vetor[j] += V;
                    }
                }
                else if (consulta[0] == "2")
                {
                    int A = int.Parse(consulta[1]);
                    int B = int.Parse(consulta[2]);

                    A--;
                    B--;

                    int resultado = vetor[A];

                    for (int j = A + 1; j <= B; j++)
                    {
                        resultado = MDC(resultado, vetor[j]);
                    }

                    Console.WriteLine(resultado);
                }
            }
        }

        static int MDC(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
    }
}