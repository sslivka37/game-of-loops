using System;

namespace LoopsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of loops!");

            
            Menu menu = new Menu();
            GamePlayer loopsGame = new GamePlayer();

            menu.DisplayMenu();

            //option 1
            loopsGame.AskForName();
            loopsGame.NameInput = Console.ReadLine();
            loopsGame.CheckForAs();

            //option 3
            loopsGame.AskForOneNumber();
            loopsGame.NumberInput = int.Parse(Console.ReadLine());
            loopsGame.CountByOdds();
            

            //2-max and min values game

            //3-count by odds game

            //4-guess the binary PIN game

            //5-name backwards (string helper?)

            //6-summation game using <List> -> look for List summation method?

            //7-create a valid username that is 4 characters long and has one letter, digit, and special character !*?#




            //play again?

            //high score with name -> to .txt file



        }
    }
}
