using System;

namespace guess_the_random_number
{
	class MainClass
	{
		/*
		 * Write a program that generates a random number between 1 and 10. Ask a user
         * to guess the random number, then display the random number and a message
         * indicating whether the user's guess was too high, too low, or correct.
         */

		public static void Main(string[] args)
		{
			Random randomGenerator = new Random();
			int randomNumber = randomGenerator.Next(1, 11);

			Console.WriteLine("Guess a number between 1 and 10");
			int userNum = int.Parse(Console.ReadLine());

			if (userNum == randomNumber)
			{
				Console.WriteLine("The number was {0}, you got it", randomNumber);
			}
			else if (userNum > randomNumber)
			{
				Console.WriteLine("The number was {0}, you were too high", randomNumber);
			}
			else
			{
				Console.WriteLine("The number was {0}, you were too low", randomNumber);
			}
		}
	}
}
