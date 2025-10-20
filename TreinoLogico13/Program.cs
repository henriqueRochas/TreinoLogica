using System.ComponentModel.Design;
using System.Globalization;

namespace TreinoLogico13;

class Program
{
    static void Main(string[] args)
    {
        int numeroUm = int.Parse(Console.ReadLine());
        int numeroDois = int.Parse(Console.ReadLine());
        int numeroTres = int.Parse(Console.ReadLine());
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;

        if (numeroUm <= numeroDois && numeroUm <= numeroTres)
        {
            if (numeroDois <= numeroTres)
            {
                n1 = numeroUm;
                n2 = numeroDois;
                n3 = numeroTres;
            }
            else
            {
                n1 = numeroUm;
                n2 = numeroTres;
                n3 = numeroDois;
            }
        }
        else if (numeroDois <= numeroUm && numeroDois <= numeroTres)
        {
            if (numeroUm <= numeroTres)
            {
                n1 = numeroDois;
                n2 = numeroUm;
                n3 = numeroTres;
            }
            else
            {
                n1 = numeroDois;
                n2 = numeroTres;
                n3 = numeroUm;
            }
        }
        else if (numeroTres <= numeroUm && numeroTres <= numeroDois)
        {
            if (numeroUm <= numeroDois)
            {
                n1 = numeroTres;
                n2 = numeroUm;
                n3 = numeroDois;
            }
            else
            {
                n1 = numeroTres;
                n2 = numeroDois;
                n3 = numeroUm;
            }
        }

        Console.WriteLine();

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);

        Console.WriteLine();

        Console.WriteLine(numeroUm);
        Console.WriteLine(numeroDois);
        Console.WriteLine(numeroTres);

    }
}