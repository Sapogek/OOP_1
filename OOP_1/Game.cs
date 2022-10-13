namespace OOP_1
{
    public class Game
    {
        public enum ResultGame
        {
            Win,
            Lose
        }
        private static double _indexGameid = 1000;
        public int Raiting { get; }
        public int IndexGame { get; }
        public string Oponent { get; }
        public ResultGame Result { get; }
        
        public Game(int raiting, string opponentName, ResultGame result)
        {
            IndexGame = (int)_indexGameid;
            _indexGameid+=0.5;
            Raiting = raiting;
            Result = result;
            Oponent = opponentName;
        }
    }
}