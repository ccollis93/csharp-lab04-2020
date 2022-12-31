using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  PROBLEM 1
             *  
             * Console.WriteLine("Please enter a number");
            int userNum = int.Parse(Console.ReadLine());
           

            int sum = 0;

            for (int i = 1; i < userNum; i++)
            {
                if (userNum % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("The sum of the factors of " + userNum + " is " + sum);
            if (sum == userNum)
                Console.WriteLine("Congratulations! " + userNum + " is a Perfect Number!");
            else
                Console.WriteLine("Sorry, " + userNum + " is not a Perfect Number :(");

            Console.ReadLine();
            */


            /* 
             * PROBLEM 2
            int num = 0;
            int sum = 0;
            int i = 1;

            Console.WriteLine("This program calculates all perfect numbers from 1 to 1000!");
            Console.WriteLine("In case you forgot, a Perfect Number is a number that is \n equal to the sum of its factors, excluding itself");
            Console.WriteLine("The Perfect Numbers from 1 to 1000 are: ");
            for (num = 1; num <= 1000; num++)
            {
                i = 1;
                sum = 0;

                while (i < num)
                {
                    if (num % i == 0)
                        sum = sum + i;
                    i++;
                }


                if (sum == num)
                    Console.WriteLine( i + " is a Perfect Number!");
            }
            Console.ReadLine(); */

            /*PROBLEM 3 */

            bool valid = false;

            Console.WriteLine("This program determines if the number you enter is prime");
            Console.WriteLine("Please enter a number");
            int userNum = int.Parse(Console.ReadLine());


            if (userNum == 0 || userNum == 1)
            {
                Console.WriteLine(userNum + " is not prime.");
                Console.ReadLine();

            }

            else
            {
                while (!valid)
                {
                    for (int i = 2; i < userNum / 2; i++)
                    {
                        if (userNum % i == 0)
                        {
                            valid = true;
                            Console.WriteLine(userNum + " is not prime.");


                            Console.ReadLine();

                        }

                    }

                    

                }
                Console.WriteLine(userNum + " is a prime number!");
                Console.ReadLine();

            }

            /* PROBLEM 4
            Random rnd = new Random();
            bool valid = false;
            int uChoice = 0;

            while (!valid) { 

            Console.WriteLine("Enter '1' for rock, '2' for paper, or '3' for scissors");


            uChoice = int.Parse(Console.ReadLine());


            int cChoice = rnd.Next(1, 3);


            if (uChoice == 1 && cChoice == 1)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");

            }

            else if (uChoice == 2 && cChoice == 2)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");
            }

            else if (uChoice == 3 && cChoice == 3)
            {
                ;
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");
            }

            else if (uChoice == 1 && cChoice == 3)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 1 && cChoice == 2)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE");
            }

            else if (uChoice == 2 && cChoice == 1)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 2 && cChoice == 3)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE!");
            }


            else if (uChoice == 3 && cChoice == 2)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 3 && cChoice == 1)
            {
                valid = true;
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE!");
            }

            else
                Console.WriteLine("ERROR, Invalid Input! Press ENTER to play again");


            Console.ReadLine();
        }
            */

            /* PROBLEM 5 
            Random rnd = new Random();
            bool valid = false;
            bool again = true;
            int uChoice = 0;
            int uWin = 0;
            int cWin = 0;

            while (!valid)
            {
                while (again == true)
                {
                    Console.WriteLine("Enter '1' for rock, '2' for paper, or '3' for scissors");


                    uChoice = int.Parse(Console.ReadLine());


                    int cChoice = rnd.Next(1, 3);


                    if (uChoice == 1 && cChoice == 1)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("TIE!");
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;

                    }

                    else if (uChoice == 2 && cChoice == 2)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("TIE!");
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 3 && cChoice == 3)
                    {
                        ;
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("TIE!");
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 1 && cChoice == 3)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU WIN!");
                        uWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 1 && cChoice == 2)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU LOSE");
                        cWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 2 && cChoice == 1)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU WIN!");
                        uWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 2 && cChoice == 3)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU LOSE!");
                        cWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }


                    else if (uChoice == 3 && cChoice == 2)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU WIN!");
                        uWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else if (uChoice == 3 && cChoice == 1)
                    {
                        valid = true;
                        Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                        Console.WriteLine("YOU LOSE!");
                        cWin++;
                        Console.WriteLine("User has " + uWin + " wins. Computer has " + cWin + " wins.");
                        Console.WriteLine("Play Again? Enter Y for yes, N for no.");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }

                    else
                        Console.WriteLine("ERROR, Invalid Input! Press ENTER to play again");


                    Console.ReadLine();
                }
            }
            */

            /* PROBLEM 6 
            Random rnd = new Random();
            int numGuess = 0;
            int cNum = rnd.Next(1, 50);
            int uNum = 0;
            bool cont = true;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("The computer picks a random number between 1 and 50");
            Console.WriteLine("If you guess it right, you win! Don't worry, we'll tell you if you guess to low or too high");
            while (cont == true)
            {
                uNum = int.Parse(Console.ReadLine());


                if (uNum == cNum)
                {
                    numGuess++;
                    Console.WriteLine("~~~** CONGRATULATIONS! YOU WIN! **~~~");
                    Console.WriteLine("It took " + numGuess + " guesses!");
                    Console.ReadLine();
                    cont = false;
                }

                else if (uNum < cNum)
                {
                    Console.WriteLine("Too Low!");
                    numGuess++;
                }

                else if (uNum > cNum)
                {
                    Console.WriteLine("Too High!");
                    numGuess++;
                }
            }
            */
        }
    }
}
