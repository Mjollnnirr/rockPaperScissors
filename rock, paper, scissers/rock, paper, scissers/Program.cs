using System;

namespace rock__paper__scissers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int userChoice;
            do
            {
                Console.WriteLine("Do you choose rock, paper or scissors");
                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n0. EXIT");
                userChoice = Convert.ToInt32(Console.ReadLine());

                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    switch (userChoice)
                    {
                        case 0:
                            continue;
                        case 1:
                            Console.WriteLine("=======================");
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine("=======================");
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 2:
                            Console.WriteLine("========================");
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine("========================");
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 3:
                            Console.WriteLine("===========================");
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine("===========================");
                            Console.WriteLine("Your point is " + count);
                            break;
                        default:
                            Console.WriteLine("========================================");
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine("========================================");
                            break;
                    }                 
                }
                if (computerChoice == 2)
                {
                    switch (userChoice)
                    {
                        case 0:
                            continue;
                        case 1:
                            Console.WriteLine("===============================");
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("Sorry you lose, paper beat rock");
                            Console.WriteLine("===============================");
                            if (count > 0)
                            {
                                count--;
                            }
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 2:
                            Console.WriteLine("====================================");
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("Sorry you lose, scissors beat paper ");
                            Console.WriteLine("====================================");
                            if (count > 0)
                            {
                                count--;
                            }
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 3:
                            Console.WriteLine("===================================");
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("Sorry you lose, rock beats scissors");
                            Console.WriteLine("===================================");
                            if (count > 0)
                            {
                                count--;
                            }
                            Console.WriteLine("Your point is " + count);
                            break;
                        default:
                            Console.WriteLine("========================================");
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine("========================================");
                            break;
                    }
                }
                if (computerChoice == 3)
                {
                    switch (userChoice)
                    {
                        case 0:
                            continue;
                        case 1:
                            Console.WriteLine("============================");
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("You win, rock beats scissors");
                            Console.WriteLine("============================");
                            count++;
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 2:
                            Console.WriteLine("=========================");
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("You win, paper beats rock");
                            Console.WriteLine("=========================");
                            count++;
                            Console.WriteLine("Your point is " + count);
                            break;
                        case 3:
                            Console.WriteLine("============================");
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("You win, scissors beat paper");
                            Console.WriteLine("============================");
                            count++;
                            Console.WriteLine("Your point is " + count);
                            break;
                        default:
                            Console.WriteLine("========================================");
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine("========================================");
                            break;
                    }
                }
            } while (userChoice != 0);
        }
    }
}
