﻿namespace JogoCorridaDeDados.Entities
{
    internal class Dice
    {
        public int SideNumber { get; set; }

        public Dice()
        {
        }

        public Dice(int sideNumber)
        {
            SideNumber = sideNumber;
        }

        public void DiceRoll()
        {
            Random randomNumber = new Random();
            SideNumber = randomNumber.Next(1, 6);
        }
    }
}
