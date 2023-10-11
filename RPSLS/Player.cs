using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            gestures = new List<string> {"rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
    internal class HumanPlayer : Player 
    {
        public HumanPlayer(string name) : base(name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        public override void ChooseGesture()
        {
            Console.WriteLine($"\nRock\nPaper\nScissors\nLizard\nSpock\n\n{name}, Choose a gesture!\n");
            chosenGesture = Console.ReadLine();

            
        }
    }
    internal class ComputerPlayer : Player 
    {
        public ComputerPlayer(string name) : base(name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        public override void ChooseGesture()
        {
            Random random = new Random();
            int num = random.Next(4);
            chosenGesture = gestures[num];
            
        }
    }    
}
