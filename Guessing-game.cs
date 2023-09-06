using System.IO;
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Generate a random number between 1 and 100
        int attempts = 0; // Track the number of attempts
        int guess = 0; // Initialize the guess variable
        bool guessedCorrectly = false; // Flag to indicate if the correct number has been guessed

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Enter a number between 1 and 100 to begin");

        while (!guessedCorrectly)
        {
            Console.Write("Take a guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess)) // Check if the input can be parsed as an integer
            {
                if (guess >= 1 && guess <= 100) // Check if the input is within the desired range
                {
                    attempts++;

                    if (guess == randomNumber) // Check if the guess is correct
                    {
                        guessedCorrectly = true;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
    }
}