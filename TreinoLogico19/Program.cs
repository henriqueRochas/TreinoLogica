using System.Globalization;

namespace TreinoLogico19;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Salario atual: ");
        double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double novoSalario = 0;
        int[] percentual = [15,12,10,7,4];
        double percentualGanho = 0;
        if (salario >= 0 && salario <= 400.00)
        {
            novoSalario = salario + (salario * (percentual[0] / 100.0));
            percentualGanho = percentual[0];
        }
        else if ( salario <= 800.00)
        {
            novoSalario = salario + (salario * (percentual[1] / 100.0));
            percentualGanho = percentual[1];
        }
        else if (salario <= 1200.00)
        {
            novoSalario = salario + (salario * (percentual[2] / 100.0));
            percentualGanho = percentual[2];
        }
        else if (salario <= 2000.00)
        {
            novoSalario = salario + (salario * (percentual[3] / 100.0));
            percentualGanho = percentual[3];
        }
        else if (salario > 2000.00)
        {
            novoSalario = salario + (salario * (percentual[4] / 100.0));
            percentualGanho = percentual[4];
        }
        double reajuste = novoSalario - salario;

        Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {percentualGanho.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}