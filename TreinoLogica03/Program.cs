using System.Globalization;

namespace TreinoLogico13;

class Program
{
    static void Main(string[] args)
    {
        int diaDaSemana = int.Parse(Console.ReadLine());

        switch (diaDaSemana)
        {
          case 1: 
              Console.WriteLine("Domingo");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Não há envios. Serviço indisponível."); 
              break;
          case 2: 
                Console.WriteLine("Segunda");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Padrão");
                break;
          case 3:
                Console.WriteLine("Terça");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Padrão");
                break;
          case 4:
                Console.WriteLine("Quarta");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Padrão");
                break;
          case 5:
                Console.WriteLine("Quinta");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Padrão");
                break;
          case 6:
                Console.WriteLine("Sexta");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Padrão");
                break;
          case 07:
                Console.WriteLine("Sábado");
                Console.WriteLine($"Dia {diaDaSemana}: " + "Envio Expresso. Custo Adicional.");
                break;
          default:
                Console.WriteLine("Erro: Dia da semana inválido.");
                break;
        }
    }
}