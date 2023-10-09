using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            { 
                Console.WriteLine("Welcome to RPSLS! Here are the rules:\nRock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n\nBest two out of three!"); 
            }            

        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nHow many are fighting today, 1 or 2?");
            string players = Console.ReadLine();
            int numberOfPlayers = Convert.ToInt16(players);
       
            return numberOfPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("What is this fighter's name?");
                string playerName = Console.ReadLine();
                HumanPlayer playerOne;
                ComputerPlayer playerTwo;
                

            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("What is the first fighter's name?");
                string playerNameOne = Console.ReadLine();
                HumanPlayer playerOne;
                Console.WriteLine("What is the second fighter's name?");
                string playerNameTwo = Console.ReadLine();
                HumanPlayer playerTwo;

            }
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            //Step 1: Display the rules of the game.
            WelcomeMessage();
            //Rock crushes Scissors
            //Scissors cuts Paper
            //Paper covers Rock
            //Rock crushes Lizard
            //Lizard poisons Spock
            //Spock smashes Scissors
            //Scissors decapitates Lizard
            //Lizard eats Paper
            //Paper disproves Spock
            //Spock vaporizes Rock

            //Step 2: Ask how many human players will be playing. (Single Player or Multi Player)
            ChooseNumberOfHumanPlayers();

            //Step 3: Prompt the 1st Player to provide a name for themselves
            //Step 4: if there is a 2nd human Player, prompt them to provide a name for themselves.
            //Step 5:  Display all of the possible options to Player 1 and have them select the gesture they would like to play
            //Step 6: if there is a human Player 2, display all of the possible options to Player 2 and have them select the gesture they would like to play; else, the computer will choose(random).
            //Step 7: Display the choices made by both players.
            //Step 8: Based off the rules of the game, display the winner of the round and why they won.
            //Step 9: Repeat Step 5, Step 6, Step 7, and Step 8.
            //Step 10: If the same player wins the second time, display that this player won the game and display a contratulations message.Otherwise, continue repeating steps 5, 6, 7, and 8 until one of the players has won two rounds.

        }
    }
}
