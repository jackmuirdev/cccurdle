class WordleGame
{
    // Introduction
    // Say hello welcome to CCCurdle
    // Instructions to play the game
    static void Introduction()
    {
        Console.WriteLine("Welcome to Wordle!");
        Console.WriteLine("Try to guess the secret word.");
        Console.WriteLine("Enter a 5-letter word");
    }

    // CPU picks a random word from the library
    static string GenerateSecretWord()
    {
        string[] words = { "apple", "grape", "melon", "peach" };
        Random random = new Random();
        return words[random.Next(words.Length)];
    }

    // User inputs a guess
    // Checks if the guess is 5 chars
    // Checks if the guess is a char
    // If int then print Invalid entry try again!
    // Can't continue without a 5-char input
    static string GetPlayerGuess()
    {
        Console.Write("Enter your guess: ");
        return Console.ReadLine().ToLower();
    }

static void DisplayGuessFeedback(string secretWord, string guess)
{
    // Compare each char to CPU string
    for (int i = 0; i < secretWord.Length; i++)
    {
        // If char == char then highlight green
        if (secretWord[i] == guess[i])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(guess[i] + " ");
        }
        // If char == char but in a different space highlight yellow
        else if (secretWord.Contains(guess[i]))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(guess[i] + " ");
        }
        // If char != char highlight red
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(guess[i] + " ");
        }
    }

    Console.ForegroundColor = ConsoleColor.White; // Reset console color
    Console.WriteLine();
}



    // Main Code
    static void Main()
    {
        // Introduction
        // Say hello welcome to CCCurdle
        // Instructions to play the game
        Introduction();

        // CPU picks a random word from the library
        string secretWord = GenerateSecretWord();
        // Get 6 guesses
        int maxAttempts = 6;
        int attempts = 0;

        // After the user guess, print Guess Again!
        while (attempts < maxAttempts)
        {
            Console.WriteLine($"Attempt {attempts + 1}/{maxAttempts}");
            string guess = GetPlayerGuess();

            // If the user guess == CPU guess print You guessed correctly, well done! End
            if (guess == secretWord)
            {
                Console.WriteLine("Congratulations! You guessed the correct word!");
                break;
            }

            DisplayGuessFeedback(secretWord, guess);
            attempts++;
        }

        // If user guesses <= 0 print Sorry you ran out of guesses - the correct word is ... End
        if (attempts == maxAttempts)
        {
            Console.WriteLine($"Sorry, you've run out of attempts. The correct word was: {secretWord}");
        }

        Console.ReadLine(); // Pause before exiting
        // Ask the user to play again (y/n)
    }
}
