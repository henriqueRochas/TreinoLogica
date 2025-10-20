namespace TreinoLogico17;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("HORARIO DE INICIO: ");
        int horarioInicio = int.Parse(Console.ReadLine());

        Console.Write("HORARIO DE TERMINO: ");
        int horarioTermino = int.Parse(Console.ReadLine());

        int duracao;

        if (horarioInicio == horarioTermino)
        {
            duracao = 24;
        }
        else if (horarioInicio < horarioTermino)
        {
            duracao = horarioTermino - horarioInicio;
        }
        else
        {
            duracao = (24 - horarioInicio) + horarioTermino;
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
    }
}