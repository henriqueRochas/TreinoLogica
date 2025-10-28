namespace TreinoLogico39
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int contM = 0;
            int contF = 0;

            for (int i = 0; i < n; i++)
            {
                string nomeGen = Console.ReadLine();
                string[] separacao = nomeGen.Split(' ');
                string gen = separacao[1];

                if (gen == "M")
                {
                    contM++;
                }
                else
                {
                    contF++;
                }
            }

            Console.WriteLine($"{contM} carrinhos");
            Console.WriteLine($"{contF} bonecas");
        }
    }
}