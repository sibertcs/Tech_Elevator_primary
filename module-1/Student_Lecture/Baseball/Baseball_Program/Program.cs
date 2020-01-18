using System;

namespace Baseball_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will prompt the user for the number of players on the team 
            //for each player, we will need their name, # of times at bat, and # of hits
            //then we'll display the player name and batting average for every player 
            //then we'll display the player with the best batting avergage

            Console.WriteLine("How many players are on your team?");
            string strNumPlayers = Console.ReadLine();
            int numPlayers = int.Parse(strNumPlayers);
            while (numPlayers <= 0 || numPlayers > 20)
            {
                Console.WriteLine("Invalid. Please enter number of players between 1 and 20");
                strNumPlayers = Console.ReadLine();
                numPlayers = int.Parse(strNumPlayers);
            }

            //to do maybe - just save the batting average
            string[] playerNames = new string[numPlayers];
            int[] timesAtBat = new int[numPlayers];
            int[] numHits = new int[numPlayers];
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Enter player name: ");
                playerNames[i] = Console.ReadLine();

                Console.WriteLine("Enter times " + playerNames[i] + " has been at bat: ");
                string strTimesAtBat = Console.ReadLine();
                timesAtBat[i] = int.Parse(strTimesAtBat);

                Console.WriteLine("Enter number of hits: ");
                string strNumHits = Console.ReadLine();
                numHits[i] = int.Parse(strNumHits);
            }
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine(playerNames[i] + " " + CalculateBattingAverage(numHits[i], timesAtBat[i]));
            }
            string playerNameWithBestAverage = "nobody";
            double bestAverage = 0;
            for (int i = 0; i < numPlayers; i++)
            {
                 if ( (double)numHits[i]/timesAtBat[i] > bestAverage)
                {
                    playerNameWithBestAverage = playerNames[i];
                    bestAverage = (double)numHits[i] / timesAtBat[i];
                }
            }
        }
        public static string CalculateBattingAverage (int numHits, int timesAtBat)
        {
            double battingAverage = (double)numHits / timesAtBat;
            battingAverage = battingAverage * 1000;
            int intBA = (int)battingAverage;
            return ". " + intBA;
        }





    } 
    







}
