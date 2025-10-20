
namespace TreinoLogico20;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Primreira definição: ");
        string primeira = Console.ReadLine();
        Console.Write("Segunda definição: ");
        string segunda = Console.ReadLine();
        Console.Write("Terceira definição: ");
        string terceira = Console.ReadLine();

        if (primeira == "vertebrado")
        {
            if (segunda == "ave")
            {
                if (terceira == "carnivoro")
                {
                    Console.WriteLine("Aguia");
                }

                else if (terceira == "onivoro")
                {
                    Console.WriteLine("Pomba");
                }
            }
            else if (segunda == "mamifero")
            {
                if (terceira == "onivoro")
                {
                    Console.WriteLine("Homem");
                }

                else if (terceira == "herbivoro")
                {
                    Console.WriteLine("Vaca");
                }
            }

        }
        else if (primeira == "invertebrado")
        {
            if (segunda == "inseto")
            {
                if (terceira == "hematofago")
                {
                    Console.WriteLine("Pulga");
                }
                else if (terceira == "herbivoro")
                {
                    Console.WriteLine("Lagarta");
                }

            }
            else if (segunda == "anelideo")
            {
                if (terceira == "hematofago")
                {
                    Console.WriteLine("Sanguessuga");
                }
                else if (terceira == "onivoro")
                {
                    Console.WriteLine("Minhoca");
                }
            }
        }
    }
}