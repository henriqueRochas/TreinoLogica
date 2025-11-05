// 1149

namespace TreinoLogico65
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0;

            int[] nA = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (nA[1] <= 0)
            {

                nA[1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nA[1]; i++)
            {

                soma += nA[0] + i;
            }

            Console.WriteLine(soma);
        }
    }
}