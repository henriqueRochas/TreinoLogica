namespace TreinoLogico18;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("HORARIO DE INÍCIO: ");
        int horarioInicio = int.Parse(Console.ReadLine());

        Console.Write("MINUTO DE INÍCIO: ");
        int minutoInicio = int.Parse(Console.ReadLine());

        Console.Write("HORARIO DE TÉRMINO: ");
        int horarioTermino = int.Parse(Console.ReadLine());

        Console.Write("MINUTO DE TÉRMINO: ");
        int minutoTermino = int.Parse(Console.ReadLine());

        int duracao;

        int convertHoraInicio = (horarioInicio * 60) + minutoInicio;
        int convertHoraTermino = (horarioTermino * 60) + minutoTermino;

        if (convertHoraInicio > convertHoraTermino)
        {
            duracao = (convertHoraTermino + 1440) - convertHoraInicio;
        }
        else
        {
            duracao =  convertHoraTermino - convertHoraInicio;
        }

        if (duracao == 0)
        {
            duracao = 1440;
        }
       
        Console.WriteLine($"O JOGO DUROU {duracao / 60} HORAS(S) E {duracao % 60} MINUTO(S)");
    }
}