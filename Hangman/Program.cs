using Hangman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer = 'y';
            int qGuess = 0;
            int q = 0;
            int qWon = 0;
            int qLoss = 0;
            char guess = 'a';
            int x = 0;
            do
            {
                Console.Clear();
                Game game = new Game();
                string s = game.ManHanging();
                int turn = 1;
                q++;

                while (!game.GameEnded())
                {
                    Console.WriteLine("GAME " + q);
                    string manHanging = game.ManHanging();
                    Console.WriteLine(manHanging);

                    Console.WriteLine();
                    Console.Write("Word: ");
                    if (turn == 1)
                    {
                        Console.WriteLine(game.Guess());
                    }
                    else
                    {
                        Console.WriteLine(game.Guess(guess));
                    }
                    int score = game.Score;

                    Console.WriteLine();
                    Console.Write("Letters guessed: ");
                    game.GuessedLettersAlphabetic.Sort();
                    foreach (char c in game.GuessedLettersAlphabetic)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Your guess: ");
                    guess = char.Parse(Console.ReadLine());
                    if (game.GuessHasBeenGuessed(guess))
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("GAME " + q);
                            Console.WriteLine(manHanging);

                            Console.WriteLine();
                            Console.Write("Word: ");
                            if (turn == 1)
                            {
                                Console.WriteLine(game.Guess());
                            }
                            else
                            {
                                Console.WriteLine(game.Guess(guess));
                            }
                            Console.WriteLine();
                            Console.Write("Letters guessed: ");
                            game.GuessedLettersAlphabetic.Sort();
                            foreach (char c in game.GuessedLettersAlphabetic)
                            {
                                Console.Write(c + " ");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("This letter has been guessed already!");
                            Console.Write("Your guess: ");
                            guess = char.Parse(Console.ReadLine());
                        } while (game.GuessHasBeenGuessed(guess));
                    }
                    game.AddScore(guess);

                    turn++;
                    if (game.Score < game.MaxScore)
                    {
                        Console.Clear();
                    }
                }

                if (game.Score == game.MaxScore)
                {
                    Console.Clear();
                    Console.WriteLine("GAME " + q);
                    string manHangingg = game.ManHanging();
                    Console.WriteLine(manHangingg);
                    Console.WriteLine();
                    Console.Write("Word: ");
                    foreach (char c in game.Word)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Letters guessed: ");
                    game.GuessedLettersAlphabetic.Sort();
                    foreach (char c in game.GuessedLettersAlphabetic)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You won!! :D");
                    qWon++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("GAME " + q);
                    string manHangingg = game.ManHanging();
                    Console.WriteLine(manHangingg);
                    Console.WriteLine();
                    Console.WriteLine("You lost... :(");
                    qLoss++;
                    Console.Write("The word was: ");
                    foreach (char c in game.Word)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
                Console.Write("Play again? (y/n): ");
                answer = char.Parse(Console.ReadLine());
            } while (answer == 'y');

            Console.WriteLine();
            Console.WriteLine("Thanks for playing! :3");
            Console.WriteLine("This game is fully open source btw, find it at");
            Console.WriteLine("https://github.com/Rafa-X9/Hangman");
            Console.WriteLine();
            Console.WriteLine("Games played: " + q);
            Console.WriteLine("Games won: " + qWon);
            Console.WriteLine("Games lost: " + qLoss);
        }
    }
}
