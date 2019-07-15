using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string cSecretWord = "giraffe"; //
            string cGuess = "";             //
            int iGuessCount = 0;            //
            int iGuessLimit = 5;            //
            bool bOutOfGuesses = false;     //
            int iGuessLength;
            int iParse = 1;
            string cBitGuess = "";
            string cCorrect = "";
            bool bFound = false;

            while (cGuess != cSecretWord && !bOutOfGuesses)  //
            {
                Console.Write("Enter guess: ");          //
                cGuess = Console.ReadLine();             //
                iGuessCount++;                           //

                iGuessLength = cGuess.Length;
                Console.WriteLine("Your guess has " + iGuessLength + " characters.");
            }                                            //

            Console.Write("You WIN ! ! !");              //

            Console.ReadLine();                          //
           
        }
        static string cCorrect(cGuess)
        {
            string cCorrectGuess;
            string cBitGuess = " ";
            string cSubGuess = " ";
            int iGuessLength;
            int iposition = 0;
            bool bGoodGuess = false;

            iGuessLength = cGuess.Length;

            while (iposition <= iGuessLength)
            {
                cSubGuess = cGuess.Substring(iposition, 1);

                switch ()
                {
                    case "g":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    case "i":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    case "r":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    case "a":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    case "f":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    case "e":
                        cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                        bGoodGuess = true;
                        iposition++;
                        break;
                    default:
                        break;
                }

            }

            return cCorrectGuess; 
        }
    }

}
