namespace JogoCorridaDeDados.Entities
{
    internal class Player
    {
        public int Position { get; set; } = 0;
        public bool Turn { get; set; } = true;

        public Player()
        {
        }

        public Player(int position)
        {
            Position = position;
        }

        public Player(int position, bool turn)
        {
            Position = position;
            Turn = turn;
        }
    }
}
