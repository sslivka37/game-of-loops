using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class WhileLoopsGamePlayer
    {
        public List<int> randomBinaryPin { get; set; }

        public void AskForPin()
        {
            Console.WriteLine("Please enter a 3-Digit PIN that is in Binary format (ie, 0 or 1).");
        }

        public void CreateRandomPin()
        {
            var tempList = new List<int>();

            Random random = new Random();
            int firstDigit = random.Next(0, 2);
            int secondDigit = random.Next(0, 2);
            int thirdDigit = random.Next(0, 2);

            tempList.Add(firstDigit);
            tempList.Add(secondDigit);
            tempList.Add(thirdDigit);

            randomBinaryPin = tempList;
            Console.WriteLine(randomBinaryPin[0]);
            Console.WriteLine(randomBinaryPin[1]);
            Console.WriteLine(randomBinaryPin[2]);
        }

    }
}
