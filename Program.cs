using System;

namespace Assinment7GussmyNumber
{
    class GenerateRandomNo
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine();
                Console.WriteLine("***** GUESSING NUMBER GAME*******");
                Console.WriteLine();

                int randomNumber,
                    guessNum, totalAttempt = 0;
                Console.WriteLine();
                string TryMore = "Y";

                while (TryMore.ToUpper() == ("Y"))
                {
                    randomNumber = GenerateRandomNo.RandomNumber(1, 100);
                    Console.WriteLine();
                    Console.WriteLine("Hey You! Give me a number!");

                    while (!int.TryParse(Console.ReadLine(), out guessNum) || guessNum < 0)
                    {
                        Console.WriteLine("Invalid number Please try again");
                        Console.WriteLine("Try with valid Number");
                    }
                    if (randomNumber == guessNum)
                    {
                        Console.WriteLine("congratulation !!!! you are the number one ");
                    }
                    else if (randomNumber < guessNum)
                    {
                        Console.WriteLine("Sorry your Guess is Max.Please try Again");
                    }
                    else if (randomNumber > guessNum)
                    {
                        Console.WriteLine("Sorry your Guess is Min.Please try Again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!!!! Please try again");
                    }
                    totalAttempt++;
                    Console.WriteLine();
                    Console.Write("Press [ENTER] for hidden number :");
                    Console.ReadLine();
                    Console.WriteLine(randomNumber);

                    Console.WriteLine();
                    Console.WriteLine("Want to try Again[Y/N: ");
                    TryMore = Console.ReadLine();

                }
                Console.WriteLine();
                Console.WriteLine("Total attempt made " + totalAttempt);
                Console.ReadLine();
            }
        }
    }
}