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
            private string userGuess;
            public void Play(string[] args)
            {
//mark was here
                NumberGuessingGame myObj = new NumberGuessingGame();
//help
                myObj.userGuess = Console.ReadLine();
                GameLogic newGameObject = new GameLogic();
                newGameObject.Checkguess(Convert.ToInt16(myObj.userGuess));
            }
            //jy is vet

        }

        class GameLogic
        {
            public static int GetRandomNumber()
            {
                Random random = new Random();
                int value1 = random.Next(1, 101);
                return value1;
            }
            public int randomValue = GetRandomNumber();

            public void Checkguess(int userGuess)
            {
                bool checkGuess = false;
                string message;
                while (!checkGuess)
                {
                    GameLogic randomNumber = new GameLogic();
                    if (userGuess == randomNumber.randomValue)
                    {
                        message = "Correct guess!";
                    }
                    else
                    {
                        message = "Incorrect guess";
                        userGuess = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine(message);
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Guess a random number!");
                NumberGuessingGame newNumberGuessingGame = new NumberGuessingGame();
                newNumberGuessingGame.Play(args);
            }
        }
    }
}
