using System;
using System.Buffers.Text;
using System.Collections.Generic;
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
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            return 0;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

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

            //Step 2: Ask how many human players will be playing. (Single Player or Multi Player)
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
