// 1114

namespace TreinoLogico51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool acesso = true;

            while(acesso = true)
            {
                string senha = Console.ReadLine();

                if(senha != "2002")
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    acesso = false;
                    break;
                }
            }
        }
    }
}
