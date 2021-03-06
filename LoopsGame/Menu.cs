﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class Menu
    {
        private GameArcade _gameArcade;
        public int MenuInput { get; set; }
        public string PlayAgainInput { get; set; }

        public Menu(GameArcade gameArcade)
        {
            this._gameArcade = gameArcade;
        }

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
            Console.WriteLine("Press 8 to view High Scores.");
            Console.WriteLine("Press 9 to Exit");

            
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

        public void AskForValidUserName()
        {
            Console.WriteLine("Enter a valid User Name");
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
                Console.WriteLine($"Thank you for playing! Your high score is {_gameArcade.HighScore}");
                _gameArcade.RecordHighScore();                
                Environment.Exit(0);
            }
        }

        

        public void ExitGame()
        {
            Environment.Exit(0);
        }

        
    }
}
