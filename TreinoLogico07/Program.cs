using System;
using System.Net;

namespace TreinoLogico13;

/*
 
 * 1 - Leia 4 valores inteiros A, B, C e D. - OK
 
 * 2 - A seguir, se B for maior do que C 
 
 * 3 - e se D for maior do que A,
 
 * 4 - e a soma de C com D for maior que a soma de A e B
 
 * 5 - e se C e D, ambos forem positivos
 
 * 6 - e se a variável A for par escrever a mensagem "Valores aceitos"
 
 * 7 - senão escrever "Valores nao aceitos".

*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor de D: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int soma1 = d + c;
        int soma2 = a + b;
        if (b > c && d > a && soma1 > soma2 && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine($"O valor de A é {a}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"O valor de B é {b}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"O valor de C é {c}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"O valor de D é {d}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"O valor da soma entre A + B é {soma2}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"O valor da soma entre D + C é {soma1}");
            Console.WriteLine("-------------------");
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores não aceitos.");
        }
    }
}