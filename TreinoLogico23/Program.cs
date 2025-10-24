using System.Xml;

namespace TreinoLogico23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int mes = int.Parse(Console.ReadLine());

            string[] meses = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

            if (mes >= 1 && mes <= 12)
            {
                int indice = mes - 1;
                Console.Write($"{meses[indice]}");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            /*
            switch (mes)
            {
                case 1:
                    Console.Write("January");
                    break;
                case 2:
                    Console.Write("February");
                    break;
                case 3:
                    Console.Write("March");
                    break;
                case 4:
                    Console.Write("April");
                    break;
                case 5:
                    Console.Write("May");
                    break;
                case 6:
                    Console.Write("June");
                    break;
                case 7:
                    Console.Write("July");
                    break;
                case 8:
                    Console.Write("August");
                    break;
                case 9:
                    Console.Write("September");
                    break;
                case 10:
                    Console.Write("October");
                    break;
                case 11:
                    Console.Write("November");
                    break;
                case 12:
                    Console.Write("December");
                    break;
                default:
                    Console.Write("Esse número não esta cadastrado");
                    break;
            }
            */
        }
    }
}