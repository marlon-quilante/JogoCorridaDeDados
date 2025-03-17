using JogoCorridaDeDados.Controllers;

namespace JogoCorridaDeDados
{
    internal class Program
    {
        static void Main()
        {
            GameController progressService = new GameController();
            inicio:
            try
            {
                Console.Clear();
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("\n1- Iniciar nova partida");
                Console.WriteLine("2- Sair do jogo\n");

                int menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Bem-vindo(a) à corrida de dados! Seu oponente será seu próprio computador...\n");
                        progressService.Game();
                        goto inicio;
                    case 2:
                        Console.WriteLine("\nJogo encerrado... Até mais!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        goto inicio;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto inicio;
            }
        }
    }
}
