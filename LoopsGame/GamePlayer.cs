using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class GamePlayer
    {

        public string NameInput { get; set; }
     

        public void AskForName ()
        {
            Console.WriteLine("Please enter your first and last name:");
        }
        
        public void CheckForAs()
        {
            char checkForA = 'A';
            int numberOfAs = 0;

            for (int i = 0; i < NameInput.Length; i++)
            {
                if (NameInput[i].Equals(char.ToUpper(checkForA)))
                {
                    numberOfAs++;
                }
            }

            Console.WriteLine($"{NameInput} has {numberOfAs} letter 'a's!");
        }




        



    }
}
