namespace TreinoLogico16;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("C: ");
        double c = double.Parse(Console.ReadLine());

        if(a + b > c && a + c > b && b + c > a)
        {
            if((a * a) == (b * b) + (c * c))
            {
                Console.WriteLine("Triangulo Retangulo");
            }
            else if ((a * a) > (b * b) + (c * c))
            {
                Console.WriteLine("Triangulo Obtusangulo");
            }
            else if((a * a) < (b * b) + (c * c))
            {
                Console.WriteLine("Triangulo Acutangulo");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Triangulo Equilatero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triangulo Isoceles");
            }
        }
        else
        {
            Console.WriteLine("Não forma Triangulo");
        }
    }
}