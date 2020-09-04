using System;

namespace Participation1_Sumof3Numbers
{
    class Program
    {
        //@author, collaborated with Rysa Khan on this assignment
        const double NUM = 7.777;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string InputNumOne = Console.ReadLine();
            double NumOne = Convert.ToDouble(InputNumOne);
            // stores user input for the first value

            Console.WriteLine("Enter second number");
            string InputNumTwo = Console.ReadLine();
            double NumTwo = Convert.ToDouble(InputNumTwo);
            // stores user input for second value 

            Console.WriteLine("Enter third number");
            string InputNumThree = Console.ReadLine();
            double NumThree = Convert.ToDouble(InputNumThree);
            // stores user input for third value

            double SumOfThree = NumOne + NumTwo + NumThree;
            Console.WriteLine("Sum of three inputs is: " + SumOfThree);
            // adds and prints the sum

            double SecondValue = SumOfThree * NUM;
            Console.WriteLine("The second value is: " + SecondValue);
            // multiplies the summed value with the constant double and prints it
        }
    }
}
