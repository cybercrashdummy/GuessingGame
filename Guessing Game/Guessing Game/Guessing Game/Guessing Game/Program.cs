using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string cSecretWord = "giraffe", cGuess = "", cCorrectLetters = "";//, cCorrectGuess = ""; //
            int iGuessCount = 0, iGuessLimit = 5, iGuessLength;            //
            bool bOutOfGuesses = false;     //

            //do
            //{
                while (cGuess.ToLower() != cSecretWord && !bOutOfGuesses)  //
                {
                    if (iGuessCount < iGuessLimit)
                    {
                        Console.Write("Enter guess: ");          //
                        cGuess = Console.ReadLine();             //
                        iGuessCount++;                           //

                        iGuessLength = cGuess.Length;
                        Console.WriteLine("Your guess has " + iGuessLength + " characters.");
                        //Console.WriteLine("25=== cCorrectLetter is >>>" + cCorrectLetters + "<<<");
                        if ((iGuessLimit - iGuessCount) != 1)
                        {
                            cCorrectLetters = Correct(cGuess, cCorrectLetters);
                            if (cCorrectLetters != "")
                            {
                                Console.WriteLine("The Letters" + cCorrectLetters + " were correct");
                            }
                            Console.WriteLine("you have " + (iGuessLimit - iGuessCount) + " guesses left.");
                    }
                        else
                        {
                            Console.WriteLine("This is your LAST try!");
                            cCorrectLetters = Correct(cGuess, cCorrectLetters);
                            if (cCorrectLetters != "")
                            {
                                Console.WriteLine("The Letters" + cCorrectLetters + " were correct");
                            }
                            bOutOfGuesses = true;
                        }
                    }

                }
                switch (bOutOfGuesses)
                {
                    case false:
                        Console.Write("You WIN ! ! !");
                        break;
                    default:
                        Console.Write("You LOSE ! ! !");
                        break;
                }

                //Console.Write("Play again? Yes or No");
                //cPlayAgain = Console.ReadLine();

            //} while (cPlayAgain != "No");

            Console.ReadLine();
        }
        //Method Correct  -- Figures out how many and what letters were correct in the guess
        static string Correct(string cGuess, string cMethodCorrectGuess)
        {
            //string cCorrectGuess = "";
            //string cBitGuess = "";
            string cSubGuess = "";
            int iGuessLength;
            int iposition = 0;
            int iCorrectCount = 0;
            //bool bGoodGuess = false;
            //bool bUsedG = false;

            iGuessLength = cGuess.Length;
            //Console.WriteLine("Method found cGuess length of " + iGuessLength);
            //Console.WriteLine("bUsedG is " + bUsedG);
            //Console.WriteLine("74=== cMethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
            while (iposition < iGuessLength)
            {
                cSubGuess = cGuess.Substring(iposition, 1);

                switch (cSubGuess)
                {
                    case "g":
                        if (cMethodCorrectGuess.ToLower().Contains("g") )
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True G");
                            //Console.WriteLine("87=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False G");
                            //Console.WriteLine("97=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                        
                    case "i":
                        if (cMethodCorrectGuess.ToLower().Contains("i"))
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True I");
                            //Console.WriteLine("111=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False I");
                            //Console.WriteLine("119=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                    case "r":
                        if (cMethodCorrectGuess.ToLower().Contains("r"))
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True R");
                            //Console.WriteLine("132=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False R");
                            //Console.WriteLine("440=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                    case "a":
                        if (cMethodCorrectGuess.ToLower().Contains("a"))
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True A");
                            //Console.WriteLine("153=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False A");
                            //Console.WriteLine("161=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                    case "f":
                        if (cMethodCorrectGuess.ToLower().Contains("f"))
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True F");
                            //Console.WriteLine("174=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False F");
                            //Console.WriteLine("182=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                    case "e":
                        if (cMethodCorrectGuess.ToLower().Contains("e"))
                        {
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            iCorrectCount++;
                            //Console.WriteLine("True E");
                            //Console.WriteLine("195=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        }
                        else
                        {
                            cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                            //bGoodGuess = true;
                            //Console.WriteLine("False E");
                            //Console.WriteLine("203=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                            iposition++;
                            iCorrectCount++;
                            break;
                        }
                    default:
                        //if (cMethodCorrectGuess != "")
                        //{
                            //cCorrectGuess = cCorrectGuess + " " + cSubGuess;
                            //bGoodGuess = true;
                            iposition++;
                            //Console.WriteLine("True E");
                            //Console.WriteLine("215=== MethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
                            break;
                        //}
                        //else
                        //{
                        //    cMethodCorrectGuess = cMethodCorrectGuess + " \"" + cSubGuess + "\"";
                        //    //bGoodGuess = true;
                        //    //Console.WriteLine("False E");
                        //    //Console.WriteLine("223=== MethodCorrectGuess >>>" + cMethodCorrectGuess + "<<<");
                        //    iposition++;
                        //    break;
                        //}
                }

            }

            if (iCorrectCount != 1)
            {
                Console.WriteLine("You gurssed " + iCorrectCount + " Letters correctly");
            }
            else
            {
                Console.WriteLine("You gurssed " + iCorrectCount + " Letter correctly");
            }
            //Console.WriteLine("239=== cMethodCorrectGuess is >>>" + cMethodCorrectGuess + "<<<");
            return cMethodCorrectGuess; //, bGoodGuess;
        }
    }
}
