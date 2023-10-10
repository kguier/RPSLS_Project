﻿using System;
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
            int numberOfHumanPlayers = Convert.ToInt16(players);
       
            return numberOfHumanPlayers;
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
            Console.WriteLine(playerOne.chosenGesture);
            Console.WriteLine(playerTwo.chosenGesture);
            //i'm sure there was a better way that wasted less time but this is what my brain understood and I have committed to it
            if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors") { Console.WriteLine("Rock smashes scissors into pieces! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "rock") { Console.WriteLine("Rock smashes scissors into pieces! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper") { Console.WriteLine("Scissors cuts paper into confetti! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "scissors") { Console.WriteLine("Scissors cuts paper into confetti!  ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock") { Console.WriteLine("Paper wraps around rock and suffocates it! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper") { Console.WriteLine("Paper wraps around rock and suffocates it!  ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard") { Console.WriteLine("Rock crushes lizard and it can't move! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "rock") { Console.WriteLine("Rock crushes lizard and it can't move! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "Spock") { Console.WriteLine("Lizard poisons Spock; he's incapacitated! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "lizard") { Console.WriteLine("Lizard poisons Spock; he's incapacitated! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "scissors") { Console.WriteLine("Spock puts the scissors away while cleaning up! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "Spock") { Console.WriteLine("Spock puts the scissors away while cleaning up! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard") { Console.WriteLine("Scissors cuts lizard's tail off! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "scissors") { Console.WriteLine("Scissors cuts lizard's tail off! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper") { Console.WriteLine("Lizard chews paper up and spits it out; paper is too soggy to fight! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "lizard") { Console.WriteLine("Lizard chews paper up and spits it out; paper is too soggy to fight!  ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "Spock") { Console.WriteLine("Paper called Spock's work derivitive; he blinked! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "paper") { Console.WriteLine("Paper called Spock's work derivitive; he blinked!  ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "rock") { Console.WriteLine("Spock threw the rock at Bones; Bones got mad and spaced rock! ${playerOne.name} wins this round!"); playerOne.score++; }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "Spock") { Console.WriteLine("Spock threw the rock at Bones; Bones got mad and spaced rock! ${playerTwo.name} wins this round!"); playerTwo.score++; }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "rock") { Console.WriteLine("It's a tie!"); }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "scissors") { Console.WriteLine("It's a tie!"); }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "paper") { Console.WriteLine("It's a tie!"); }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "lizard") { Console.WriteLine("It's a tie!"); }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Spock") { Console.WriteLine("It's a tie!"); }

        }

        public void DisplayGameWinner()
        {
            while (playerOne.score == 2)
            {
                Console.WriteLine("Congratulations," + playerOne.name + "! You have defeated your opponent!");
            }
            while (playerTwo.score == 2)
            {
                Console.WriteLine("Congratulations," + playerTwo.name + "! You have defeated your opponent!");
            }
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
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
        
            

            //Step 3: Prompt the 1st Player to provide a name for themselves
            //Step 4: if there is a 2nd human Player, prompt them to provide a name for themselves.
            CreatePlayerObjects(numberOfHumanPlayers);

            //Step 5:  Display all of the possible options to Player 1 and have them select the gesture they would like to play
            //Step 6: if there is a human Player 2, display all of the possible options to Player 2 and have them select the gesture they would like to play; else, the computer will choose(random).
            string chosenGesture = ChooseGesture();
           
            
            //Step 7: Display the choices made by both players.
            //Step 8: Based off the rules of the game, display the winner of the round and why they won.
            CompareGestures();
            //Step 9: Repeat Step 5, Step 6, Step 7, and Step 8.
            //Step 10: If the same player wins the second time, display that this player won the game and display a contratulations message.Otherwise, continue repeating steps 5, 6, 7, and 8 until one of the players has won two rounds.
            DisplayGameWinner();
        }
    }
}
