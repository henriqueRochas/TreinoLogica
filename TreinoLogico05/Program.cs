// Seeusing System.Globalization;

namespace TreinoLogico13;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        int saldoAtual = (int)Math.Round(n * 100);

        Console.WriteLine("NOTA DE R$100,00");
        int nota100 = saldoAtual / 10000;
        saldoAtual = saldoAtual % 10000;
        Console.WriteLine(nota100);

        Console.WriteLine("NOTA DE R$50,00");
        int nota50 = saldoAtual / 5000;
        saldoAtual = saldoAtual % 5000;
        Console.WriteLine(nota50);

        Console.WriteLine("NOTA DE R$20,00");
        int nota20 = saldoAtual / 2000;
        saldoAtual = saldoAtual % 2000;
        Console.WriteLine(nota20);

        Console.WriteLine("NOTA DE R$10,00");
        int nota10 = saldoAtual / 1000;
        saldoAtual = saldoAtual % 1000;
        Console.WriteLine(nota10);

        Console.WriteLine("NOTA DE R$5,00");
        int nota5 = saldoAtual / 500;
        saldoAtual = saldoAtual % 500;
        Console.WriteLine(nota5);

        Console.WriteLine("NOTA DE R$2,00");
        int nota2 = saldoAtual / 200;
        saldoAtual = saldoAtual % 200;
        Console.WriteLine(nota2);

        Console.WriteLine("MOEDA DE R$1,00");
        int moeda100 = saldoAtual / 100;
        saldoAtual = saldoAtual % 100;
        Console.WriteLine(moeda100);

        Console.WriteLine("MOEDA DE R$0,50");
        int moeda50 = saldoAtual / 50;
        saldoAtual = saldoAtual % 50;
        Console.WriteLine(moeda50);

        Console.WriteLine("MOEDA DE R$0,25");
        int moeda25 = saldoAtual / 25;
        saldoAtual = saldoAtual % 25;
        Console.WriteLine(moeda25);

        Console.WriteLine("MOEDA DE R$0,10");
        int moeda10 = saldoAtual / 10;
        saldoAtual = saldoAtual % 10;
        Console.WriteLine(moeda10);

        Console.WriteLine("MOEDA DE R$O,05");
        int moeda5 = saldoAtual / 5;
        saldoAtual = saldoAtual % 5;
        Console.WriteLine(moeda5);

        Console.WriteLine("MOEDA DE R$O,01");
        int moeda1 = saldoAtual / 1;
        saldoAtual = saldoAtual % 1;
        Console.WriteLine(moeda1);

        Console.WriteLine(saldoAtual);


    }
}