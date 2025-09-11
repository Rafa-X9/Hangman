using Hangman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    guess = GuessToLower(guess);

                    if (!IsALetter(guess))
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
                            Console.WriteLine("Invalid character!");
                            Console.Write("Your guess: ");
                            guess = char.Parse(Console.ReadLine());
                        } while (!IsALetter(guess));
                    }

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

        static char GuessToLower(char c)
        {
            if (c == 'A') { return 'a'; }
            if (c == 'B') { return 'b'; }
            if (c == 'C') { return 'c'; }
            if (c == 'D') { return 'd'; }
            if (c == 'E') { return 'e'; }
            if (c == 'F') { return 'f'; }
            if (c == 'G') { return 'g'; }
            if (c == 'H') { return 'h'; }
            if (c == 'I') { return 'i'; }
            if (c == 'J') { return 'j'; }
            if (c == 'K') { return 'k'; }
            if (c == 'L') { return 'l'; }
            if (c == 'M') { return 'm'; }
            if (c == 'N') { return 'n'; }
            if (c == 'O') { return 'o'; }
            if (c == 'P') { return 'p'; }
            if (c == 'Q') { return 'q'; }
            if (c == 'R') { return 'r'; }
            if (c == 'S') { return 's'; }
            if (c == 'T') { return 't'; }
            if (c == 'U') { return 'u'; }
            if (c == 'V') { return 'v'; }
            if (c == 'W') { return 'w'; }
            if (c == 'X') { return 'x'; }
            if (c == 'Y') { return 'y'; }
            if (c == 'Z') { return 'z'; }
            else { return '!'; }
        }

        static bool IsALetter(char c)
        {
            return c == 'a' ||
            c == 'b' ||
            c == 'c' ||
            c == 'd' ||
            c == 'e' ||
            c == 'f' ||
            c == 'g' ||
            c == 'h' ||
            c == 'i' ||
            c == 'j' ||
            c == 'k' ||
            c == 'l' ||
            c == 'm' ||
            c == 'n' ||
            c == 'o' ||
            c == 'p' ||
            c == 'q' ||
            c == 'r' ||
            c == 's' ||
            c == 't' ||
            c == 'u' ||
            c == 'v' ||
            c == 'w' ||
            c == 'x' ||
            c == 'y' ||
            c == 'z';
        }
    }
}