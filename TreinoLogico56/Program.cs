//1131

namespace TreinoLogico56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gols;

            int somaInter = 0;
            int contVitoriasInter = 0;
            int contVitoriasGremio = 0;
            int contEmpates = 0;
            int somaGremio = 0;
            int contGrenais = 0;

            while (true)
            {
                gols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Console.WriteLine("Novo grenal (1-sim 2-nao");
                int sn = int.Parse(Console.ReadLine());

                contGrenais++;


                if (gols[0] == gols[1])
                {
                    contEmpates++;
                }
                else if (gols[0] > gols[1])
                {
                    contVitoriasInter++;
                }
                else
                {
                    contVitoriasGremio++;
                }

                if (sn == 1)
                {
                    continue;
                }
                else if (sn == 2)
                {
                    Console.WriteLine($"{contGrenais} grenais");
                    Console.WriteLine($"Inter: {contVitoriasInter}");
                    Console.WriteLine($"Gremio: {contVitoriasGremio}");
                    Console.WriteLine($"Empates: {contEmpates}");

                    if (contVitoriasInter > contVitoriasGremio)
                    {
                        Console.WriteLine("Inter venceu mais");
                    }
                    else if (contVitoriasGremio > contVitoriasInter)
                    {
                        Console.WriteLine("Gremio venceu mais");
                    }
                    else
                    {
                        Console.WriteLine("Ambos estão empadatos em vitorias");
                    }

                    break;
                }
            }
        }
    }
}
