using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

public interface IWordleGame
{
    string StartNewGame();
    string Guess(string gameId, string guess);
}

public class WordleGame : IWordleGame
{
    private Dictionary<string, string> games = new Dictionary<string, string>();

    public string StartNewGame()
    {
        string gameId = GenerateGameId();
        string secretWord = GenerateSecretWord();
        games.Add(gameId, secretWord);
        return gameId;
    }

    public string Guess(string gameId, string guess)
    {
        if (games.TryGetValue(gameId, out string secretWord))
        {
            // Implement your Wordle game logic here
            // Compare the guess with the secretWord and return the result
            // For simplicity, let's say a correct guess returns "You win!" and a wrong guess returns "Try again."
            if (string.Equals(guess, secretWord, StringComparison.OrdinalIgnoreCase))
            {
                return "You win!";
            }
            else
            {
                return "Try again.";
            }
        }
        else
        {
            return "Game not found.";
        }
    }

    private string GenerateGameId()
    {
        // Implement your own logic to generate a unique game ID
        return Guid.NewGuid().ToString("N");
    }

    private string GenerateSecretWord()
    {
        // Implement your own logic to generate a secret word for the game
        // For simplicity, let's use a predefined list of words
        string[] wordList = { "apple", "banana", "orange", "grape", "melon" };
        Random random = new Random();
        return wordList[random.Next(0, wordList.Length)];
    }
}

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Services.AddSingleton<IWordleGame, WordleGame>().Build();

        app.MapGet("/start", (IWordleGame wordleGame) => wordleGame.StartNewGame());
        app.MapGet("/guess", (IWordleGame wordleGame, HttpContext context) =>
        {
            string gameId = context.Request.Query["gameId"];
            string guess = context.Request.Query["guess"];
            return wordleGame.Guess(gameId, guess);
        });

        app.Run();
    }
}
