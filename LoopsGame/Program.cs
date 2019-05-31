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
            menu.MenuInput = int.Parse(Console.ReadLine());

            while (menu.MenuInput > 0 && menu.MenuInput <= 8)
            {

                //option 1- checking for as

                if (menu.MenuInput == 1)
                {
                    menu.AskForName();
                    gameArcade.NameInput = Console.ReadLine();
                    gameArcade.CheckForAs();
                }



                //option 2- finding max and min from user input

                if (menu.MenuInput == 2)
                {


                    menu.AskForFiveNumbers();

                    var userIntList = new List<int>();
                    for (int i = 0; i < 5; i++)
                    {
                        string userInput = Console.ReadLine();
                        int userInt;

                        if (Int32.TryParse(userInput, out userInt))
                        {
                            userIntList.Add(userInt);
                        }
                    }
                    gameArcade.MaxAndMinUserInput = userIntList;
                    gameArcade.CheckForMaxAndMin();
                }



                //option 3- count by odds based on user input

                if (menu.MenuInput == 3)
                {
                    menu.AskForOneNumber();
                    gameArcade.NumberInput = int.Parse(Console.ReadLine());
                    gameArcade.CountByOdds();
                }



                //option 4- PIN guessing game

                if (menu.MenuInput == 4)
                {
                    int[] userPinArray = new int[3];
                    gameArcade.CreateRandomPin();

                    int numberOfTries = 0;

                    while (numberOfTries < 3)
                    {


                        menu.AskForPin();
                        for (int i = 0; i < 3; i++)
                        {
                            string userInput = Console.ReadLine();
                            int userInt;

                            if (Int32.TryParse(userInput, out userInt))
                            {
                                userPinArray[i] = userInt;
                            }
                        }

                        gameArcade.UserGuessedPin = userPinArray;

                        gameArcade.CheckIfPinMatches();

                        if (gameArcade.IsMatching)
                        {
                            break;
                        }

                        numberOfTries++;
                    }

                }



                //option 5 - Name Backwards

                if (menu.MenuInput == 5)
                {
                    menu.AskForName();
                    gameArcade.NameInput = Console.ReadLine();
                    gameArcade.ReverseName();
                }



                //option 6 - Sum of range between low and high number

                if (menu.MenuInput == 6)
                {
                    menu.AskForLowInt();
                    gameArcade.LowInt = int.Parse(Console.ReadLine());
                    menu.AskForHighInt();
                    gameArcade.HighInt = int.Parse(Console.ReadLine());
                    gameArcade.DetermineSummation();
                }


                //option 7- create a valid username that is at least four characters long, has one letter, one digit, and one special character !*?#

                if (menu.MenuInput == 7)
                {
                    int numberOfTries = 0;
                    while (numberOfTries < 3)
                    {
                        menu.AskForValidUserName();
                        gameArcade.UserName = Console.ReadLine();
                        gameArcade.CheckUserName();

                        if (gameArcade.IsValidUserName == true)
                        {
                            break;
                        }
                    }
                }

                //option 8 - exit game
                if (menu.MenuInput == 8)
                {
                    Console.WriteLine($"Your score is {gameArcade.HighScore}!");
                    menu.ExitGame();
                    
                }

                menu.AskToPlayAgain();
                menu.PlayAgainInput = Console.ReadLine();
                menu.CheckPlayAgain();
                menu.MenuInput = int.Parse(Console.ReadLine());


                
                //high score with name -> to .txt file

            }

            

        }
    }
}
