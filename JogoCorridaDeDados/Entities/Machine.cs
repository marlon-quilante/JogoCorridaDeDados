namespace JogoCorridaDeDados.Entities
{
    internal class Machine : Player
    {
        public Machine()
        {
        }

        public void MachineAdvance()
        {
            Dice dice = new Dice();

            dice.DiceRoll();

            if (dice.SideNumber == 6)
            {
                Position += dice.SideNumber;
                dice.DiceRoll();
                Position += dice.SideNumber;
                bool positionExtraAdvance = MachinePositionExtraAdvance();
                bool positionReturn = MachinePositionReturn();

                if (positionExtraAdvance == true)
                {
                    Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                        + " e caiu em uma casa sorteada."
                        + "\nPor conta disso, ele avançou mais 3 casas e agora está na posição "
                        + Position + ".\n");
                }
                else
                {
                    if (positionReturn == true)
                    {
                        Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                            + " e caiu em uma casa com armadilha."
                            + "\nPor conta disso, ele retrocedeu 2 casas e agora está na posição "
                            + Position + ".\n");
                    }
                    else
                    {
                        Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                        + " e agora está na posição " + Position + ".\n");
                    }
                }
            }
            else
            {
                Position += dice.SideNumber;
                bool positionExtraAdvance = MachinePositionExtraAdvance();
                bool positionReturn = MachinePositionReturn();

                if (positionExtraAdvance == true)
                {
                    Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                        + " e caiu em uma casa sorteada."
                        + "\nPor conta disso, ele avançou mais 3 casas e agora está na posição "
                        + Position + ".\n");
                }
                else
                {
                    if (positionReturn == true)
                    {
                        Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                            + " e caiu em uma casa com armadilha."
                            + "\nPor conta disso, ele retrocedeu 2 casas e agora está na posição "
                            + Position + ".\n");
                    }
                    else
                    {
                        Console.WriteLine("Seu oponente tirou o número " + dice.SideNumber
                        + " e agora está na posição " + Position + ".\n");
                    }
                }
            }
        }

        public bool MachinePositionExtraAdvance()
        {
            if (Position == 5 || Position == 10 || Position == 20)
            {
                Position += 3;
                return true;
            }
            return false;
        }

        public bool MachinePositionReturn()
        {
            if (Position == 9 || Position == 15 || Position == 29)
            {
                Position -= 2;
                return true;
            }
            return false;
        }

        public void MachineTurnUpdate()
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
