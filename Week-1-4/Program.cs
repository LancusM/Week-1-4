using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Excercise 4, user calculates 2 numbers in either of the four main math equations, picks one, and gets their results (twice, for some reason)
            //establishes variables of each equation so it can be called at the end
            string plus = "addition";
            string minus = "subtraction";
            string multi = "multiplication";
            string div = "division";
            //Title/Acknowledgment to user
            Console.WriteLine("CALCULATOR APPLICATION");
            //Asks for first number in equation
            Console.Write("What is the first number? ");
            //using the float.Parse, gets firstNum
            float firstNum = float.Parse(Console.ReadLine());
            //Asks for second number in equation
            Console.Write("What is the second number? ");
            //using the float.Parse, gets secondNum
            float secondNum = float.Parse(Console.ReadLine());
            //Displays to user the four possible equations to pursue
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            //Gives user choice of math
            Console.Write("Enter your choice (1-4): ");
            //using the float.Parse, gets users choice
            float choice = float.Parse(Console.ReadLine());
            /* The (way too complicated) if else statement to check for each number, rspective to each possible equation.
             * I tried to find work arounds, but I didn't understand them, so I simply went the usable but inefficient way and had the result display
             * in every option, instead of funnelling them all into one at the end. I know it's not perfect and not a great version, but at least it works. */
            if (choice == 1)
            {
                /* Checks if choice is 1, and if so, computes the addition equation, gets the answer, inputs the string from earlier with addition, and outputs the results. */
                float answer = firstNum + secondNum;
                string equation = plus;
                Console.WriteLine("The result of " + equation + " is: " + answer);
                Console.WriteLine("Here is the result: " + answer);
            }
            else if (choice == 2)
            {
                /* After checking for 1, checks if choice is 2, and if so, computes the subtraction equation, gets the answer,
                 * inputs the string from earlier with subtraction, and outputs the results. */
                float answer = firstNum - secondNum;
                string equation = minus;
                Console.WriteLine("The result of " + equation + " is: " + answer);
                Console.WriteLine("Here is the result: " + answer);
            }
            else if (choice == 3)
            {
                /* After checking for 1 & 2, checks if choice is 3, and if so, computes the multiplication equation, gets the answer,
                 * inputs the string from earlier with multiplication, and outputs the results. */
                float answer = firstNum * secondNum;
                string equation = multi;
                Console.WriteLine("The result of " + equation + " is: " + answer);
                Console.WriteLine("Here is the result: " + answer);
            }
            else
            {
                /* After checking everything, and uses everything not those to compute the division equation, gets the answer,
                 * inputs the string from earlier with division, and outputs the results. */
                //I couldn't understand how to get the else statement to work correctly, so I made it that 4 and higher does division. I did try, however.
                float answer = firstNum / secondNum;
                string equation = div;
                Console.WriteLine("The result of " + equation + " is: " + answer);
                Console.WriteLine("Here is the result: " + answer);
            }
        }
    }
}