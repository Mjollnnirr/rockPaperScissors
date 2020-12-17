using System;

namespace rock__paper__scissers
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.WriteLine("Do you choose rock, paper or scissors");
                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n0. EXIT");
                userChoice = Console.ReadLine();

                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "0")
                    {
                        break;
                    }
                    else if (userChoice == "1")
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine("=======================");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("========================");
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine("========================");
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine("===========================");
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("You must choose rock, paper or scissors!");
                        Console.WriteLine("========================================");
                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "0")
                    {
                        break;
                    }
                    else if (userChoice == "1")
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose, paper beat rock");
                        Console.WriteLine("===============================");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("====================================");
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose, scissors beat paper ");
                        Console.WriteLine("====================================");
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("===================================");
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose, rock beats scissors");
                        Console.WriteLine("===================================");
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("You must choose rock, paper or scissors!");
                        Console.WriteLine("========================================");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "0")
                    {
                        break;
                    }
                    else if (userChoice == "1")
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win, rock beats scissors");
                        Console.WriteLine("============================");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win, paper beats rock");
                        Console.WriteLine("=========================");
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win, scissors beat paper");
                        Console.WriteLine("============================");
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("You must choose rock, paper or scissors!");
                        Console.WriteLine("========================================");
                    }

                }
            } while (userChoice != "0");
        }
    }
}
