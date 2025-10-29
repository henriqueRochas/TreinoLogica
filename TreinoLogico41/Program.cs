using System.Reflection.Metadata;

namespace TreinoLogico41
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            if (n.Contains("13"))
            {
                Console.WriteLine($"{n} Es de mala suerte");
            }
            else
            {
                Console.WriteLine($"{n} No es de mala suerte");
            }
        }
    }
}