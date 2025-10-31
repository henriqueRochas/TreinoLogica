// 1115

namespace TreinoLogico52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool parada = true;

            while (parada = true)
            {
                string coordenadas = Console.ReadLine();
                string[] xy = coordenadas.Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                if (x == 0 || y == 0)
                {
                    parada = false;
                    break;
                }

                if(x > 0 &&  y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if(y > 0 && x < 0 )
                {
                    Console.WriteLine("segundo");
                }
                else if(x < 0 && y < 0 )
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}
