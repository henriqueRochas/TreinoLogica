namespace TreinoLogico26;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Dia inicio");
        int diaInicio = int.Parse(Console.ReadLine());
        int horarioInicio = int.Parse(Console.ReadLine());
        int minutosInicio = int.Parse(Console.ReadLine());
        int segundosInicio = int.Parse(Console.ReadLine());

        Console.Write("Dia termino");
        int diaTermino = int.Parse(Console.ReadLine());
        int horarioTermino = int.Parse(Console.ReadLine());
        int minutosTermino = int.Parse(Console.ReadLine());
        int segundosTermino = int.Parse(Console.ReadLine());

        int segundosDiaInicio = (diaInicio * 86400) + (horarioInicio * 3600) + (minutosInicio * 60) + segundosInicio;
        int segundosDiaTermino = (diaTermino * 86400) + (horarioTermino * 3600) + (minutosTermino * 60) + segundosTermino;

        int duracao = segundosDiaTermino - segundosDiaInicio;

        int w = duracao / 86400;
        int segundosRestantes = duracao % 86400;
        int x = segundosRestantes / 3600;
        segundosRestantes = segundosRestantes % 3600;
        int y = segundosRestantes / 60;
         segundosRestantes = segundosRestantes % 60;
        int z = segundosRestantes;



        Console.WriteLine($"{w} dias(s)");
        Console.WriteLine($"{x} hora(s)");
        Console.WriteLine($"{y} minutos(s)");
        Console.WriteLine($"{z} segundo(s)");
    }
}