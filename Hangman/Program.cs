using Hangman.Entities;
using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer = 'y';
            int qGuess = 0;
            int q = 1;
            char guess = 'a';
            int x = 0;
            do
            {
                Console.Clear();
                Game game = new Game();
                string s = game.ManHanging();
                int turn = 1;

                while (!game.GameEnded())
                {
                    Console.WriteLine("GAME " + q);
                    Console.WriteLine("Word = " + game.Word); //retirar!!!
                    Console.WriteLine("Score: " + game.Score + "/" + game.MaxScore); //retirar
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
                    Console.Write("Your guess: ");
                    guess = char.Parse(Console.ReadLine());
                    game.AddScore(guess);

                    turn++;
                    if (game.Score < game.MaxScore)
                    {
                        Console.Clear();
                    }
                }

                Console.Clear();
                Console.WriteLine("GAME " + q);
                Console.WriteLine("Word = " + game.Word); //retirar!!!
                Console.WriteLine("Score: " + game.Score + "/" + game.MaxScore); //retirar
                string manHangingg = game.ManHanging();
                Console.WriteLine(manHangingg);
                Console.WriteLine();
                Console.Write("Word: ");
                foreach (char c in game.Word)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();

                if (game.Score == game.MaxScore)
                {
                    Console.WriteLine("You won!! :D");
                }
                q++;
                Console.Write("Play again? (y/n): ");
                answer = char.Parse(Console.ReadLine());
            } while (answer == 'y');
        }
    }
}
