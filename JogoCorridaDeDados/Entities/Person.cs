namespace JogoCorridaDeDados.Entities
{
    internal class Person : Player
    {
        public Person()
        {
        }

        public Person(int position) : base(position)
        {
            Position = position;
        }

        public Person(int position, bool turn) : base(position, turn)
        {
            Position = position;
            Turn = turn;
        }


        public void PersonAdvance()
        {
            Dice dice = new Dice();

            Console.Write("É o seu turno! Pressione qualquer tecla para rolar o dado...");
            Console.ReadKey();
            dice.DiceRoll();
            Console.Clear();

            if (dice.SideNumber == 6)
            {
                Console.WriteLine("Você tirou o número 6! Pressione qualquer tecla para rolar o dado novamente...");
                Console.ReadLine();
                Position += dice.SideNumber;
                dice.DiceRoll();
                Position += dice.SideNumber;
                bool positionExtraAdvance = PersonPositionExtraAdvance();
                bool positionReturn = PersonPositionReturn();

                if (positionExtraAdvance == true)
                {
                    Console.WriteLine("Você tirou o número " + dice.SideNumber
                        + " e caiu em uma casa sorteada."
                        + "\nPor conta disso, você avançou mais 3 casas e agora está na posição "
                        + Position + ".\n");
                }
                else
                {
                    if (positionReturn == true)
                    {
                        Console.WriteLine("Você tirou o número " + dice.SideNumber
                            + " e caiu em uma casa com armadilha."
                            + "\nPor conta disso, você retrocedeu 2 casas e agora está na posição "
                            + Position + ".\n");
                    }
                    else
                    {
                        Console.WriteLine("Você tirou o número " + dice.SideNumber
                        + " e agora está na posição " + Position + ".");
                    }
                }
            }
            else
            {
                Position += dice.SideNumber;
                bool positionExtraAdvance = PersonPositionExtraAdvance();
                bool positionReturn = PersonPositionReturn();

                if (positionExtraAdvance == true)
                {
                    Console.WriteLine("Você tirou o número " + dice.SideNumber
                        + " e caiu em uma casa sorteada."
                        + "\nPor conta disso, você avançou mais 3 casas e agora está na posição "
                        + Position + ".\n");
                }
                else
                {
                    if (positionReturn == true)
                    {
                        Console.WriteLine("Você tirou o número " + dice.SideNumber
                            + " e caiu em uma casa com armadilha."
                            + "\nPor conta disso, você retrocedeu 2 casas e agora está na posição "
                            + Position + ".\n");
                    }
                    else
                    {
                        Console.WriteLine("Você tirou o número " + dice.SideNumber
                        + " e agora está na posição " + Position + ".\n");
                    }
                }
            }
        }

        public bool PersonPositionExtraAdvance()
        {
            if (Position == 5 || Position == 10 || Position == 20)
            {
                Position += 3;
                return true;
            }
            return false;
        }

        public bool PersonPositionReturn()
        {
            if (Position == 9 || Position == 15 || Position == 29)
            {
                Position -= 2;
                return true;
            }
            return false;
        }

        public void PersonTurnUpdate()
        {
            if (Turn == false)
            {
                Turn = true;
            }
            else
            {
                Turn = false;
            }
        }
    }
}
