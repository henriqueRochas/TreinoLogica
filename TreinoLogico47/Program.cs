namespace TreinoLogico47
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int I = 1;
             int J = 60;

            while (J >= 0)
            {
                I = I + 3;
                J = J - 5;

                Console.WriteLine($"I = {I}" );
                Console.WriteLine($"J = {J}");
            }
        }
    }
}
