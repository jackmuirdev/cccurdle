// Introduction
// Say hello welcome to CCCurdle
// Instructions to play game

// CPU picks random word form library

// Split string into characters

// Say input your guess

// User inputs guess
// Checks guess is 5 chars
// Checks guess is an char
// If int then print Invalid entry try again!
// Cant continue without an 5 char input

// Split string into char

// Compare each char to cpu string 

// If char == char then highlight green 
// If char == char but in different space highlight yellow
// If char != char highlight red

// loop the last few lines of code

// Get 6 guesses

// If user guess == cpu guess print You guessed correctly, well done! End
// After user guess print Guess Again!
// Print how many guesses left
// If user guesses =< 0 print Sorry you ran out of guesses - correct word is ... End

// Ask user to play again (y/n)

using System;
using System.Linq;

class WordleGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to Wordle!");
        Console.WriteLine("Try to guess the secret word.");

        string secretWord = GenerateSecretWord();
        int maxAttempts = 6;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Console.WriteLine($"Attempt {attempts + 1}/{maxAttempts}");
            string guess = GetPlayerGuess();

            if (guess == secretWord)
            {
                Console.WriteLine("Congratulations! You guessed the correct word!");
                break;
            }

            DisplayGuessFeedback(secretWord, guess);
            attempts++;
        }

        if (attempts == maxAttempts)
        {
            Console.WriteLine($"Sorry, you've run out of attempts. The correct word was: {secretWord}");
        }

        Console.ReadLine(); // Pause before exiting
    }

    static string GenerateSecretWord()
    {
        string[] words = { "apple", "banana", "orange", "grape", "melon", "peach" };
        Random random = new Random();
        return words[random.Next(words.Length)];
    }

    static string GetPlayerGuess()
    {
        Console.Write("Enter your guess: ");
        return Console.ReadLine().ToLower();
    }

    static void DisplayGuessFeedback(string secretWord, string guess)
    {
        char[] feedback = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guess[i])
            {
                feedback[i] = 'O'; // Correct letter in the correct position
            }
            else if (secretWord.Contains(guess[i]))
            {
                feedback[i] = 'X'; // Correct letter in the wrong position
            }
            else
            {
                feedback[i] = '_'; // Incorrect letter
            }
        }

        Console.WriteLine("Feedback: " + new string(feedback));
        Console.WriteLine();
    }
}
