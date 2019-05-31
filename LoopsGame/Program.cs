using System;
using System.Collections.Generic;

namespace LoopsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of loops!");

            
            Menu menu = new Menu();
            GameArcade gameArcade = new GameArcade();
            

            menu.DisplayMenu();

            ////option 1- checking for as
            //menu.AskForName();
            //gameArcade.NameInput = Console.ReadLine();
            //gameArcade.CheckForAs();

            ////option 2- finding max and min from user input
            //menu.AskForFiveNumbers();

            //var userIntList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    string userInput = Console.ReadLine();
            //    int userInt;

            //    if (Int32.TryParse(userInput, out userInt))
            //    {
            //        userIntList.Add(userInt);
            //    }
            //}

            //gameArcade.MaxAndMinUserInput = userIntList;
            //gameArcade.CheckForMaxAndMin();

            ////option 3- count by odds based on user input
            //menu.AskForOneNumber();
            //gameArcade.NumberInput = int.Parse(Console.ReadLine());
            //gameArcade.CountByOdds();

            ////option 4- PIN guessing game
            //int[] userPinArray = new int [3];
            //gameArcade.CreateRandomPin();

            //int numberOfTries = 0;

            //while (numberOfTries < 3)
            //{


            //    menu.AskForPin();
            //    for (int i = 0; i < 3; i++)
            //    {
            //        string userInput = Console.ReadLine();
            //        int userInt;

            //        if (Int32.TryParse(userInput, out userInt))
            //        {
            //            userPinArray[i] = userInt;
            //        }
            //    }

            //    gameArcade.UserGuessedPin = userPinArray;

            //    gameArcade.CheckIfPinMatches();

            //    if (gameArcade.IsMatching)
            //    {
            //        break;
            //    }

            //    numberOfTries ++;
            //}


            ////option 5 - Name Backwards
            //menu.AskForName();
            //gameArcade.NameInput = Console.ReadLine();
            //gameArcade.ReverseName();

            //option 6 - Sum of range between low and high number
            menu.AskForLowInt();
            gameArcade.LowInt = int.Parse(Console.ReadLine());
            menu.AskForHighInt();
            gameArcade.HighInt = int.Parse(Console.ReadLine());
            gameArcade.DetermineSummation();




            

            

            //7-create a valid username that is 4 characters long and has one letter, digit, and special character !*?#




            //play again?

            //high score with name -> to .txt file



        }
    }
}
