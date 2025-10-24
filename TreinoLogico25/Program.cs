namespace TreinoLogico26;

class Program
{
    static void Main(string[] args)
    {
        double num;
        int cont = 0;

        for (int i = 0; i < 6; i++)
        {
            num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                cont++;
            }
        }
        Console.WriteLine($"{cont} valores positivos");
    }
}