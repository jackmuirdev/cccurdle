class CCCurdleGame
{
    private static WordLibrary wordLibrary = new WordLibrary(); // Make wordLibrary static

    static void Introduction()
    {
        Console.WriteLine("Welcome to CCCurdle");
        Console.WriteLine("Try to guess the secret word.");
        Console.WriteLine("Enter a 5-letter word");
    }

    // Remove GenerateSecretWord method

    static string GetPlayerGuess()
    {
        Console.Write("Enter your guess: ");
        string guess = Console.ReadLine()?.ToLower();

        if (guess == null || guess.Length != 5)
        {
            Console.WriteLine("Invalid word - needs to be 5 characters");
            return null;
        }

        return guess;
    }

    static void DisplayGuessFeedback(string secretWord, string guess)
    {
        HashSet<int> correctPositions = new HashSet<int>();
        HashSet<char> correctLetters = new HashSet<char>();

        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guess[i] && !correctPositions.Contains(i))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(guess[i] + " ");
                correctPositions.Add(i);
                correctLetters.Add(guess[i]);
            }
            else if (secretWord.Contains(guess[i]) && !correctPositions.Contains(i) && !correctLetters.Contains(guess[i]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(guess[i] + " ");

                for (int j = 0; j < secretWord.Length; j++)
                {
                    if (secretWord[j] == guess[i])
                    {
                        correctPositions.Add(j);
                    }
                }

                correctLetters.Add(guess[i]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(guess[i] + " ");
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

    public void RunGame()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Introduction();
            string secretWord = wordLibrary.GetRandomFiveletter();
            int maxAttempts = 6;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine($"Attempt {attempts + 1}/{maxAttempts}");
                string guess = GetPlayerGuess();

                if (guess != null)
                {
                    if (guess == secretWord)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct word!");
                        break;
                    }

                    DisplayGuessFeedback(secretWord, guess);
                    attempts++;
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine($"Sorry, you've run out of attempts. The correct word was: {secretWord}");
            }

            Console.Write("Do you want to play again? (y/n): ");
            char playAgainInput = Console.ReadKey().KeyChar;
            playAgain = (playAgainInput == 'y' || playAgainInput == 'Y');
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
    }

    // Add the Main method back
    static void Main()
    {
        CCCurdleGame game = new CCCurdleGame();
        game.RunGame();
    }
}
