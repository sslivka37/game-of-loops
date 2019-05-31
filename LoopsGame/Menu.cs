using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class Menu
    {
        public int MenuInput { get; set; }
        public string PlayAgainInput { get; set; }

        public void DisplayMenu()
        {
            Console.WriteLine("Please choose a game to play:");
            Console.WriteLine("Press 1 to play 'Count the As in a Name' game.");
            Console.WriteLine("Press 2 to play 'Max and Min Values' game.");
            Console.WriteLine("Press 3 to play 'Count by Odds' game.");
            Console.WriteLine("Press 4 to play 'Guess the Binary PIN' game.");
            Console.WriteLine("Press 5 to play 'Backwards Name' game.");
            Console.WriteLine("Press 6 to play 'Number Summation' game");
            Console.WriteLine("Press 7 to play 'Username Creation' game.");
            Console.WriteLine("Press 8 to Exit");

            //press 8 to view high score? change exit to 9
        }

        public void AskForName()
        {
            Console.WriteLine("Please enter your first and last name:");
        }

        public void AskForFiveNumbers()
        {
            Console.WriteLine("Please enter five numbers");
        }

        public void AskForOneNumber()
        {
            Console.WriteLine("Enter a positive number");
        }

         public void AskForPin()
        {
            Console.WriteLine("Please enter a 3-Digit PIN that is in Binary format (ie, 0 or 1).");
        }

        public void AskForLowInt()
        {
            Console.WriteLine("Enter a low positive integer");
        }

        public void AskForHighInt()
        {
            Console.WriteLine("Enter a high positive integer");
        }

        public void AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? If so, type 'yes'");
                
        }

        public void CheckPlayAgain()
        {
            if (PlayAgainInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                DisplayMenu();
            }
            else 
            {
                Console.WriteLine("Thank you for playing!");
                Environment.Exit(0);
            }
        }

        //view high score menu probably would go here

        public void ExitGame()
        {
            Environment.Exit(0);
        }

        //exit method could probably record score before exiting?
    }
}
