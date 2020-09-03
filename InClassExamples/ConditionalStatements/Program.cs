using System;
// 2.1 flow control (conditionals) problem from canvas slide//
namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            bool containsHazardous = false;

            Console.WriteLine("What is the weight of your shipment, in pounds?>>");
            string response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is the distance of your shipment, in miles?>>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain hazardous material");
            response = Console.ReadLine();

            if (response == "yes")
            {
                containsHazardous = true;
            }
            else if (response == "no")
            {
                containsHazardous = false;

            }
            else
                Console.WriteLine("INVALID INPUT. GOODBYE");
            return;
        }
    }
    {
    double quote = (0.55 * distance) + (0.73 * weight);
    double hazardousCost = 0;

    if (containsHazardous == true)

        {

        hazardousCost = 0.15 * weight;

        }

        else

         { 
    
        hazardousCost=0

         }

double netTotal = quote + hazardousCost;

if (distance<150 && weight>500)
{
    discount = netTotal * 0.10;


}

double total = netTotal - discount;

Console.WriteLine();
Console.WriteLine("Quote" + quote.ToString("C"));
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hazardous Cost" + hazardousCost);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Net Total:" + netTotal);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Discount: " + discount);
Console.WriteLine($"Total: /t/t{total.ToString}");

}



