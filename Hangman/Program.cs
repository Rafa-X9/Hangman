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

                    if (IsALetter(guess) == false || game.GuessHasBeenGuessed(guess))
                    {
                        do
                        {
                            if (IsALetter(guess) == false)
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
                            else if (game.GuessHasBeenGuessed(guess))
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
                        } while (IsALetter(guess) == false || game.GuessHasBeenGuessed(guess));
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
            else if (c == 'B') { return 'b'; }
            else if (c == 'C') { return 'c'; }
            else if (c == 'D') { return 'd'; }
            else if (c == 'E') { return 'e'; }
            else if (c == 'F') { return 'f'; }
            else if (c == 'G') { return 'g'; }
            else if (c == 'H') { return 'h'; }
            else if (c == 'I') { return 'i'; }
            else if (c == 'J') { return 'j'; }
            else if (c == 'K') { return 'k'; }
            else if (c == 'L') { return 'l'; }
            else if (c == 'M') { return 'm'; }
            else if (c == 'N') { return 'n'; }
            else if (c == 'O') { return 'o'; }
            else if (c == 'P') { return 'p'; }
            else if (c == 'Q') { return 'q'; }
            else if (c == 'R') { return 'r'; }
            else if (c == 'S') { return 's'; }
            else if (c == 'T') { return 't'; }
            else if (c == 'U') { return 'u'; }
            else if (c == 'V') { return 'v'; }
            else if (c == 'W') { return 'w'; }
            else if (c == 'X') { return 'x'; }
            else if (c == 'Y') { return 'y'; }
            else if (c == 'Z') { return 'z'; }
            else { return c; }
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
            c == 'z' ||
            c == 'A' ||
            c == 'B' ||
            c == 'C' ||
            c == 'D' ||
            c == 'E' ||
            c == 'F' ||
            c == 'G' ||
            c == 'H' ||
            c == 'I' ||
            c == 'J' ||
            c == 'K' ||
            c == 'L' ||
            c == 'M' ||
            c == 'N' ||
            c == 'O' ||
            c == 'P' ||
            c == 'Q' ||
            c == 'R' ||
            c == 'S' ||
            c == 'T' ||
            c == 'U' ||
            c == 'V' ||
            c == 'W' ||
            c == 'X' ||
            c == 'Y' ||
            c == 'Z';
        }
    }
}