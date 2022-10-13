using System;
using System.Collections.Generic;

namespace OOP_1
{
    public class GameAccount
    {
        private readonly List<Game> _allGame = new List<Game>();
        public int GamesCount;
        public string UserName { get; }
        public int CurrentRaiting
        {
            get
            {
                int raiting = 500;
                foreach (var item in _allGame)
                {
                    if (raiting + item.Raiting < 0)
                    {
                        raiting = 1;
                    }
                    else {raiting += item.Raiting;}
                }

                return raiting;
            }
        }

        public GameAccount(string name)
        {
            UserName = name;
        }
        
        public void WinGame(int raiting, string opponentName)
        {
            if (raiting <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(raiting), "Raiting must be positive @_@");
            }
            else
            {
                var winG = new Game(raiting, opponentName, Game.ResultGame.Win);
                GamesCount++;
                _allGame.Add(winG);
            }
        }

        public void LoseGame(int raiting, string opponentName)
        {
            if (raiting <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(raiting), "Raiting must be positive @_@");
            }
            else
            {
                var loseG = new Game(-raiting, opponentName, Game.ResultGame.Lose);
                GamesCount++;
                _allGame.Add(loseG);
            }
        }
        
        public string GetStats()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("NameOpponent\tResult\tRaiting\tIndex");
            int raiting = 0;
            foreach (var item in _allGame)
            {
                raiting += item.Raiting;
                report.AppendLine($"{item.Oponent}\t{item.Result}\t{item.Raiting}\t{item.IndexGame}");//
            }
            return report.ToString();
        }
        
    }
}