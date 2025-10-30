//1113

namespace TreinoLogico50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool parada = true;
            
            while (parada)
            { 
                string pares = Console.ReadLine();
                string[] xy = pares.Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                if (x == y)
                {
                    parada = false;
                    break;
                }

                if (x > y)
                {
                    Console.WriteLine("Descrescente");
                    
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}
