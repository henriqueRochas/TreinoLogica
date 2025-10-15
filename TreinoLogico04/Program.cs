using System.Globalization;

namespace TreinoLogica01;

class Program
{
    static void Main(string[] args)
    {
        // FOR

        //Console.WriteLine("LANÇAMENTO EM ");

        //for (int i = 10; i >= 0; i--)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("LANÇOU!!!!");

        // WHILE

        Console.Write("Senha: ");
        string senha = Console.ReadLine();
        Console.Write("Logar: ");
        string logar = Console.ReadLine();
        int tentativa = 0;
        while (logar != senha && tentativa < 3)
        {
                Console.WriteLine("Tente novamente");
                logar = Console.ReadLine();
                tentativa++;
        }

        if (logar == senha)
        {
            Console.WriteLine("Acesso Concedido. Bem vindo");
        }
        else
        {
            Console.WriteLine("Acesso, bloqueado");
        }
    }
}