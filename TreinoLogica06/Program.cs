// Seeusing System.Globalization;

namespace TreinoLogica01;

class Program
{
    static void Main(string[] args)
    { 
        //DECOMPOSIÇÃO DE NOTAS COM LOOPING
        int[] notas = [10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1];
        string[] nomesNotas = ["NOTA DE R$100,00", "NOTA DE R$50,00", "NOTA DE R$20,00", "NOTA DE R$10,00", "NOTA DE R$5,00", "NOTA DE R$2,00",
                               "MOEDA DE R$1,00", "MOEDA DE R$0,50", "MOEDA DE R$0,25", "MOEDA DE R$0,10", "MOEDA DE R$0,05", "MOEDA DE R$0,01" ];

        double n = double.Parse(Console.ReadLine());
        int saldoAtual = (int)Math.Round(n * 100);
        
            for (int i = 0; i < notas.Length; i++)
            {
                int contagem = saldoAtual / notas[i];
                saldoAtual = saldoAtual % notas[i];

                Console.WriteLine(nomesNotas[i]);
                Console.WriteLine(contagem);
            }
    }
}