// 1145

using System;

namespace TreinoLogico63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i <= n[1]; i++)
            {
                if (i % n[0] == 0)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
               
            }
            
        }
    }
}
