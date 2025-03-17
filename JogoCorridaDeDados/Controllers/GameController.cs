using JogoCorridaDeDados.Entities;

namespace JogoCorridaDeDados.Controllers
{
    internal class GameController
    {
        public void Game()
        {
            Person person = new Person();
            Machine machine = new Machine();
            Program program = new Program();

            person.Position = 0;
            machine.Position = 0;
            person.Turn = true;
            machine.Turn = false;

            try
            {
                while (person.Position < 30 && machine.Position < 30)
                {
                    Console.WriteLine("Você: " + person.Position);
                    Console.WriteLine("Computador: " + machine.Position);
                    Console.WriteLine();

                    person.PersonAdvance();
                    person.PersonTurnUpdate();
                    machine.MachineTurnUpdate();

                    if (person.Position >= 30)
                    {
                        Console.Clear();
                        Console.WriteLine("Parabéns! Você venceu a corrida de dados!\n");
                        Console.WriteLine("Você parou na casa: " + person.Position);
                        Console.WriteLine("Seu computador parou na casa: " + machine.Position);

                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;
                    }

                    machine.MachineAdvance();
                    person.PersonTurnUpdate();
                    machine.MachineTurnUpdate();

                    if (machine.Position >= 30)
                    {
                        Console.Clear();
                        Console.WriteLine("Que pena! Seu computador venceu a corrida de dados!\n");
                        Console.WriteLine("Você parou na casa " + person.Position);
                        Console.WriteLine("Seu computador parou na casa " + machine.Position);

                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
