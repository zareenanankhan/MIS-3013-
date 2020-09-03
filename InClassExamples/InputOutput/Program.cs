
using System;


namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            // This won't work becuase it is a constant
            //CLASS NAME = "MIS 3013"
            //strng firstName, lastName;
            string firstName = "Zareen";
            string lastName = "Khan";
            Console.WriteLine( firstName+" "+lastName+ " is teaching "+ CLASS_NAME);


            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine(); //Getting what the user typed and storing it in

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
                double gpa = Convert.ToDouble(gpaInput);

            global::System.Console.WriteLine(firstName + " " + lastName + " is teaching " + CLASS_NAME + " with a GPA of " + gpa.ToString("D"));
        }
    }
}
