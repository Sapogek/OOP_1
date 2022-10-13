using System;

namespace OOP_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new GameAccount("S1mple");
            var account1 = new GameAccount("b1t");
            var account2 = new GameAccount("NiKO");
            //var invalid = new GameAccount("invalid");//
            //account.WinGame(-10,account1.UserName,"Win");//
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var hruk = random.Next(0, 6);
                var puck = random.Next(5, 100);
                if (hruk == 0)
                {
                    account.WinGame(puck,account1.UserName);
                    account1.LoseGame(puck,account.UserName);
                }
                else if (hruk == 1)
                {
                    account1.WinGame(puck,account.UserName);
                    account.LoseGame(puck,account1.UserName);
                }
                else if (hruk == 2)
                {
                    account2.WinGame(puck,account.UserName);
                    account.LoseGame(puck,account2.UserName);
                }
                else if (hruk == 3)
                {
                    account.WinGame(puck,account2.UserName);
                    account2.LoseGame(puck,account.UserName);
                }
                else if (hruk == 4)
                {
                    account1.WinGame(puck,account2.UserName);
                    account2.LoseGame(puck,account1.UserName);
                }
                else if (hruk == 5)
                {
                    account2.WinGame(puck,account1.UserName);
                    account1.LoseGame(puck,account2.UserName);
                }
            }
            Console.WriteLine("User Name: "+account.UserName+"\tCurrent_Rait: "+account.CurrentRaiting+"\t\tGame_Played: "+account.GamesCount+"\nStat for "+account.UserName+":");
            Console.WriteLine(account.GetStats());
            Console.WriteLine("User Name: "+account1.UserName+"\tCurrent_Rait: "+account1.CurrentRaiting+"\t\tGame_Played: "+account1.GamesCount+"\nStat for "+account1.UserName+":");
            Console.WriteLine(account1.GetStats());
            Console.WriteLine("User Name: "+account2.UserName+"\tCurrent_Rait: "+account2.CurrentRaiting+"\t\tGame_Played: "+account2.GamesCount+"\nStat for "+account2.UserName+":");
            Console.WriteLine(account2.GetStats());
        }
    }
}