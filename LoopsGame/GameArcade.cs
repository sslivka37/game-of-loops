using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class GameArcade
    {

        public string NameInput { get; set; }
        public List<int> MaxAndMinUserInput { get; set; }
        public int NumberInput { get; set; }
        public List<int> RandomBinaryPin { get; set; }
        public int[] UserGuessedPin { get; set; }
        public bool IsMatching { get; set; }
        public int LowInt { get; set; } 
        public int HighInt { get; set; }
        public string UserName { get; set; }
        public bool IsLongEnough { get; set; }
        public bool HasInt { get; set; }
        public bool HasLetter { get; set; }
        public bool HasSpecialChar { get; set; }
        public bool IsValidUserName { get; set; }
        public int HighScore { get; set; } = 0;



        public void CheckForAs()
        {
            char checkForCapitalA = 'A';
            char checkForLowerA = 'a';
            int numberOfAs = 0;

            for (int i = 0; i < NameInput.Length; i++)
            {
                if (NameInput[i] == checkForCapitalA || NameInput[i] == checkForLowerA)
                {
                    numberOfAs++;
                }
            }

            Console.WriteLine($"{NameInput} has {numberOfAs} letter 'a's!");
            HighScore += 10;
        }

        public void CheckForMaxAndMin()
        {
            int maximumValue = MaxAndMinUserInput[0];
            int minimumValue = MaxAndMinUserInput[0];

            for (int i = 0; i < MaxAndMinUserInput.Count; i++)
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
            HighScore += 20;
        }


        public void CountByOdds()
        {
            int loopCount = 0;
            for (int countTo = 1; countTo <= NumberInput; countTo += 2)
            {
                Console.WriteLine(countTo);
                loopCount++;

            }
            Console.WriteLine($"Counted {loopCount} odd numbers!");
            HighScore += 15;
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

            RandomBinaryPin = tempList;

            //just for testing purposes
            //Console.WriteLine(RandomBinaryPin[0]);
            //Console.WriteLine(RandomBinaryPin[1]);
            //Console.WriteLine(RandomBinaryPin[2]);
        }

        public void CheckIfPinMatches()
        {
            if (UserGuessedPin[0] == RandomBinaryPin[0] && UserGuessedPin[1] == RandomBinaryPin[1] && UserGuessedPin[2] == RandomBinaryPin[2])
            {
                Console.WriteLine("Congratulations, you have guessed the Binary PIN!");
                IsMatching = true;
                HighScore += 50;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }

        public void ReverseName()
        {
            char[] userName = NameInput.ToCharArray();
            Array.Reverse(userName);
            Console.WriteLine(userName);
            HighScore += 15;

        }

        public void DetermineSummation()
        {
            int tempLow = LowInt;
            int tempHigh = HighInt;
            int summation = 0;
            while (tempLow <= tempHigh)
            {
                summation += tempLow;
                tempLow++;
            }

            Console.WriteLine($"The sum of {LowInt} and {HighInt} and the integers in between is {summation}");
            HighScore += 30;
            
        }

        public void CheckUserName()
        {
            char[] userName = UserName.ToCharArray(); 
            
            if (userName.Length >= 4)
            {
                IsLongEnough = true;
            }
            

            for (int i =0; i <userName.Length; i++)
            {
                if (Char.IsDigit(userName[i]))
                {
                    HasInt = true;
                }
                if (Char.IsLetter(userName[i]))
                {
                    HasLetter = true;
                }
                if (userName[i] == '!' || userName[i] == '*' || userName[i] == '?' || userName[i] == '#')
                {
                    HasSpecialChar = true;
                }

            }            

            if (IsLongEnough && HasInt && HasLetter && HasSpecialChar)
            {
                Console.WriteLine("Congratulations, you have entered a valid user name!");
                IsValidUserName = true;
                HighScore += 100;
            }
            else
            {
                Console.WriteLine("Not a valid user name, try again!");
            }
           
        }

        public void RecordHighScore()
        {
            string highScoreName;
            string highScoreString;

            Console.WriteLine("Please enter your name to record high score:");
            highScoreName = Console.ReadLine();

            highScoreString = HighScore.ToString();

            using (System.IO.StreamWriter highScoreFile = new System.IO.StreamWriter(@"C:\Users\sslivka\source\repos\LoopsGame\LoopsGame\HighScore.txt", true))
            {
                highScoreFile.WriteLine(highScoreName + "-" + highScoreString);
            }
        }

        public void ViewHighScoreList()
        {
            string[] highScoreView = System.IO.File.ReadAllLines(@"C:\Users\sslivka\source\repos\LoopsGame\LoopsGame\HighScore.txt");

            var highScoreList = new SortedList<int, string>();

            for (int i = 0; i < highScoreView.Length; i++)
            {
                string [] highScoreSplit = highScoreView[i].Split('-');
                string name = highScoreSplit[0];
                int score = int.Parse(highScoreSplit[1]);

                highScoreList.Add(score, name);    
            }

            foreach (KeyValuePair<int, string> kvp in highScoreList)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }

                






            //for (int i = 0; i < highScoreView.Length; i++)
            //{
            //    Console.WriteLine(highScoreView[i]);
            //}

        }







    }



}



