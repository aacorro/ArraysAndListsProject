using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PrintTwoThounsand();

            // PrintByThree();

            // Console.WriteLine(CheckParams(12, 12));

            //Console.WriteLine(CheckEven(20));
            // Console.WriteLine(PositeOrNot(-5));

            Console.WriteLine(CanVote());
        }


        // Write a method that will print to the console all numbers 1000 through -1000.
        /*public static void PrintTwoThounsand()
        {
            for(int i = 1000; i > -1001; i--)

            Console.WriteLine($"{i}");
        }


        // Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void PrintByThree()
        {
            for (int j = 3; j <= 999; j+=3)
           
            Console.WriteLine($"{j}");
        }

        // Write a method to accept two integers as parameters and check whether they are equal or not.

        public static bool CheckParams(int num1, int num2)
        {
               
            
                var check = (num1 == num2) ? true : false;
                return check; ;
            }

        // Write a method to check whether a given number is even or odd.

        public static bool CheckEven(int age3)
        {
            var evenOrNot = (age3 % 2 == 0) ? true : false;
            return evenOrNot;
        }

        // Write a method to check whether a given number is positive or negative.


        public static bool PositeOrNot(int num5)
        {
            var positiveOrNeg = (num5 >= 0) ? true : false;
            return positiveOrNeg;
        }*/


        // Write a method to read the age of a candidate and determine whether they can vote.
        // Hint: use Parse()... or the safer TryParse() for an extra challenge!!

        public static bool CanVote()

        {
            Console.WriteLine("How old are you?");
            var userInput = Console.ReadLine();


            var userAnswer = int.Parse(userInput >= 21) ? "You may vote" : "Looks like you are too young yet";
            return userAnswer;
            }
    }
    }
}


