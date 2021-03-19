using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackagePro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");//Messasge for user that we input
            Console.WriteLine("Please enter the package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); // user puts in package weight to start program, unless its over 50 then it wont be able to ship and the program will end
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width.");// here we are asking for 3 dimensions to multiply, then divide to calculate if we can ship the package, and what the cost to ship will be
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int dimentionTotal = packageWidth + packageHeight + packageLength;
                if (dimentionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal result = dimentionTotal * packageWeight / 100m; // we divide by 100 with the results from our usres dimensions 
                    Console.WriteLine("Your estimated total for shipping this package is " + "$" + result);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}


