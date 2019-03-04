using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain = "no";

            do
            {
                Console.Clear();
                Console.WriteLine("--------------------Welcome--------------------");
                Console.WriteLine("------This is a rock paper scissors game-------");
                Console.WriteLine("---------Choose rock paper or scissors---------");
                string playerChoice = CheckPlayerString(Console.ReadLine());
                string computerChoice = RockPaperOrSciss(RNumberGenerator());

                DetermineWinner(computerChoice, playerChoice);
                if (computerChoice == playerChoice)
                {
                    TieBreaker(computerChoice, playerChoice);
                }
                Console.WriteLine("------------Thank you for playing!-------------");
                Console.WriteLine("------Would you like to play again? yes/no------");
                playAgain = Console.ReadLine();
            } while (playAgain != "no");
            Console.WriteLine("------------Thank you for playing!-------------");
            System.Threading.Thread.Sleep(2000);

        }

        private static int RNumberGenerator()
        {
            Random rng = new Random();
            int randomNumb = rng.Next(1, 4);
            return randomNumb;
        }

        private static string RockPaperOrSciss(int computerNumber)
        {
            string ComputerChoice = "";

            if (computerNumber == 1)
            {
                ComputerChoice = "rock";
            }
            if (computerNumber == 2)
            {
                ComputerChoice = "paper";
            }
            else
            {
                ComputerChoice = "scissors";
            }
            return ComputerChoice;
        }

        private static void DetermineWinner(string ComputerChoice, string PlayerChoice)
        {
            
            // winner = 1 player is the winner, winner = 2 computer is the winner, winner = 0 it's a tie
            if (ComputerChoice == PlayerChoice)
            {
                Console.WriteLine("There is no winner. You both chose {0}", ComputerChoice);
            }

            if (ComputerChoice == "rock" && PlayerChoice == "paper")
            {
                Console.WriteLine("You win! Congrats. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }

            if (ComputerChoice == "rock" && PlayerChoice == "scissors")
            {
                Console.WriteLine("Sorry! You lose. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }

            if (ComputerChoice == "paper" && PlayerChoice == "rock")
            {
                Console.WriteLine("Sorry! You lose. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }

            if (ComputerChoice == "paper" && PlayerChoice == "scissors")
            {
                Console.WriteLine("You win! Congrats. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }

            if (ComputerChoice == "scissors" && PlayerChoice == "rock")
            {
                Console.WriteLine("You win! Congrats. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }

            if (ComputerChoice == "scissors" && PlayerChoice == "paper")
            {
                Console.WriteLine("Sorry! You lose. You chose {0} and the computer chose {1}", PlayerChoice, ComputerChoice);
            }
            
        }

        private static string CheckPlayerString(string enteredChoice)
        {
            string finalChoice;

            if (enteredChoice != "rock" && enteredChoice != "paper" && enteredChoice != "scissors")
                {
                    Console.WriteLine("You have entered an incorrect value, please enter again");
                    enteredChoice = Console.ReadLine();
                }

            finalChoice = enteredChoice;
            return finalChoice;
        }

        private static void TieBreaker(string ComputerChoice, string PlayerChoice)
        {
            string newCompChoice = ComputerChoice;
            string newPlayerChoice = PlayerChoice;
            do
            {
                
                newCompChoice = RockPaperOrSciss(RNumberGenerator());
                Console.WriteLine("Pick a new choice, rock paper or scissors");
                newPlayerChoice = CheckPlayerString(Console.ReadLine());
                DetermineWinner(newCompChoice, newPlayerChoice);

            } while (newCompChoice == newPlayerChoice);
            
        }
    }
}
