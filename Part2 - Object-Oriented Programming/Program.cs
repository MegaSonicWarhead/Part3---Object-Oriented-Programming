using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Object_Oriented_Programming
{
    internal class Program
    {
        class NumberGuessingGame
        {
            private int userGuess;
            private bool gameComplete = false;
            private string guessResult;
            private readonly GameLogic newGameObject;
            public NumberGuessingGame() // class constructor
            {
                newGameObject = new GameLogic();
            }

            public void  Play()
            {
                while (!gameComplete)
                {
                    string message = "";
                    Console.WriteLine("Guess the random number!");
                    do
                    {
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        guessResult = newGameObject.CheckGuess(userGuess);

                        if (guessResult == "Match")
                        {
                            message = "Congratulations! You guessed the number!";

                        }
                        else
                        {
                            message = guessResult;
                        }

                        Console.WriteLine(message);
                    }
                    while (guessResult != "Match");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string playContinue = Console.ReadLine();
                    if(playContinue == "n")
                    {
                        gameComplete = true;
                        Environment.Exit(0);
                    }
                    
                }

            }
        }

        class GameLogic
        {
            public GameLogic() // class constructor
            {
                Random random = new Random();
                randomValue = random.Next(1, 101);
            }

            public string CheckGuess(int userGuess)
            {
                if (randomValue == userGuess)
                {
                    return "Match";
                }
                else if (randomValue < userGuess)
                {
                    return "Too High";
                }
                else
                {
                    return "Too Low";
                }
            }

            private int randomValue;
        }

        static void Main(string[] args)
        {
            NumberGuessingGame numberGuessingGameObj = new NumberGuessingGame();
            numberGuessingGameObj.Play();
        }

    }
}