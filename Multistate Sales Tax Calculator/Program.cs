using System;

namespace Multistate_Sales_Tax_Calculator
{
    class Program
    {
        static void illinoisTax() 
        {
            Console.WriteLine("Please enter the order amount:");
            double subtotal = Double.Parse(Console.ReadLine());

            Console.WriteLine("The tax in Illinois is 8%. There is no additional county-level charge");
            Console.WriteLine($"The tax on your order is " +  (subtotal * 0.08));
            Console.WriteLine($"Your total is $" + Math.Round(((subtotal * 0.08) + subtotal), 2, MidpointRounding.AwayFromZero).ToString("0.00"));
        }
        static void wisconsinTax()
        {
            Console.WriteLine("Please enter the order amount:");
            double subtotal = Double.Parse(Console.ReadLine());

            Console.WriteLine("The tax in Wisonsin is $0.50.");

            Console.WriteLine("Do you live in Eau Claire county?(Y/N)");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.WriteLine("For Eau Claire county residents, there is an additional $0.005 tax.");
                Console.WriteLine($"Your total is $" + Math.Round((subtotal + 0.50 + 0.005), 2, MidpointRounding.AwayFromZero).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Are you a Dunn county resident?(Y/N)");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine("For Dunn county residents, there is an additional $0.004 tax.");
                    Console.WriteLine($"Your total is $" + Math.Round((subtotal + 0.50 + 0.004), 2, MidpointRounding.AwayFromZero).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Your total is  $" + (subtotal + 0.50).ToString("0.00"));
                }
            }
        }
              
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Multistate Sales Tax Calculator");
            Console.WriteLine("Hello, today we are going to calculate your tax based on the state!");

            Console.WriteLine("Please be mindful that I am currently only programmed for two states: IL & WI");
            Console.WriteLine("What state do you live in?");
            string state = Console.ReadLine().ToUpper();
            if (state == "IL")
            {
                illinoisTax();
            }
            else if (state == "WI") 
            {
                wisconsinTax();
            }
            



        }
    }
}
