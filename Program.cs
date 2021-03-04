using System;

//how to keep up with how wins ??

// How to determine who wins?
//this is can be made by the numbers
//-----rock beat scissors
//-----paper beats rock
//-----scissor beats paper
//-----the same then do over


//use a random number generator for computer choice

//create and if else statement for which hand gesture to display

//
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initital Display
            Console.WriteLine("------------------------------");
            Console.WriteLine("| Player: 0  |  Computer: 2  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            string userThrow = Console.ReadLine();
        }

        //Display of hand gestures
        void RockDisplay(int rock)
        {
            Console.WriteLine($@"

                    _______
                ----'   ____)
                    (_____)
                    (_____)
                    (____)
                ---.__(___)


        ");
        }

        void PaperDisplay(int paper)
        {
            Console.WriteLine($@"

                _______
            ---'    ____)____
                        ______)
                        _______)
                        _______)
            ---.__________)


            ");
        }

        void ScissorsDisplay(int scissors)
        {
            Console.WriteLine($@"

                _______
            ---'   ____)____
                      ______)
                  __________)
                 (____)
            ---.__(___)


            ");
        }
    }
}