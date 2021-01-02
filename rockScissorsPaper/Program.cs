using System;
using System.Collections.Generic;
using System.Linq;

namespace rockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> elements = new List<string>() { "rock", "paper", "scissors" };
            int cpuScore = 0;
            int playerScore = 0;
            int gamesPlayed = 0;
            Console.WriteLine("How many games?");
            int games = int.Parse(Console.ReadLine());
            Console.WriteLine("Rock, Scissors or Paper?");
            Console.Write("Player: ");
            string inputplayer = Console.ReadLine().ToLower();

            Random rnd = new Random();
            int numOfChoice = rnd.Next(elements.Count);
            string cpuChoice = elements.ElementAt(numOfChoice);
            Console.WriteLine($"CPU: {cpuChoice}");

            while (gamesPlayed <= games)
            {
                if (cpuChoice == "rock" && inputplayer == "rock" || cpuChoice == "scissors" && inputplayer == "scissors" || cpuChoice == "paper" && inputplayer == "paper")
                {
                    Console.WriteLine("DRAW");
                    gamesPlayed++;
                }
                if (cpuChoice == "rock" && inputplayer == "scissors" || cpuChoice == "scissors" && inputplayer == "paper" || cpuChoice == "paper" && inputplayer == "rock")
                {
                    Console.WriteLine("GAME FOR CPU");
                    cpuScore++;
                    gamesPlayed++;
                }
                if (inputplayer == "rock" && cpuChoice == "scissors" || inputplayer == "scissors" && cpuChoice == "paper" || inputplayer == "paper" && cpuChoice == "rock")
                {
                    Console.WriteLine("GAME FOR PLAYER");
                    playerScore++;
                    gamesPlayed++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"CPU {cpuScore}:{playerScore} PLAYER");
                Console.WriteLine($"Games remaining: {games-gamesPlayed}");
                Console.ResetColor();
                if(games==gamesPlayed)
                {
                    break;
                }
                else
                {
                    Console.Write("Player: ");
                    inputplayer = Console.ReadLine().ToLower();
                    numOfChoice = rnd.Next(elements.Count);
                    cpuChoice = elements.ElementAt(numOfChoice);
                    Console.WriteLine($"CPU: {cpuChoice}");
                }             

            }
            Console.WriteLine("Thank for playing!");
            if (cpuScore > playerScore)
            {
                Console.WriteLine("CPU WINS");
            }
            if (playerScore > cpuScore)
            {
                Console.WriteLine("PLAYER WINS");
            }
            if (cpuScore == playerScore)
            {
                Console.WriteLine("DRAW");
            }



        }
    }
}
