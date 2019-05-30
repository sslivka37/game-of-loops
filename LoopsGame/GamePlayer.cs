﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class GamePlayer
    {

        public string NameInput { get; set; }
        public int [] MaxAndMinUserInput { get; set; }
     

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

        public void AskForFiveNumbers()
        {
            Console.WriteLine("Please enter five numbers");
        }

        public void CheckForMaxAndMin()
        {
            int maximumValue = MaxAndMinUserInput[0];
            int minimumValue = MaxAndMinUserInput[0];

            for (int i= 0; i < MaxAndMinUserInput.Length; i++)
            {
                if (MaxAndMinUserInput[i] > maximumValue)
                {
                    maximumValue = MaxAndMinUserInput[i];
                }

                if (MaxAndMinUserInput[i] < minimumValue)
                {
                    minimumValue = MaxAndMinUserInput[i];
                }
                   
            }

            Console.WriteLine($"The maxiumum value is {maximumValue} and the minimum value is {minimumValue} ");
        }
        



    }
}
