using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCompairOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");// start message we display for user
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            int hrRate1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Hours worked per week?"); // asking user for hours worked to start the operation to compair if person1 makes more than person2
            string hoursWorkedPerWeek1 = Console.ReadLine();
            int hrWorkedPerWk1 = Convert.ToInt32(hoursWorkedPerWeek1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            int hrRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week?"); // asking user for person2 infomaition to continue Math operations for compairing Data for Salary
            string hoursWorkedPerWeek2 = Console.ReadLine();
            int hrWorkedPerWk2 = Convert.ToInt32(hoursWorkedPerWeek2);
            Console.WriteLine("Annual salary of Person 1:");
            int weeksPerYear = 52;                                   // setting weeks of year so we can divide the data of hours to compair with hours works/payrates
            int product1 = hrRate1 * hrWorkedPerWk1 * weeksPerYear;
            Console.WriteLine(product1);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2:");
            int product2 = hrRate2 * hrWorkedPerWk2 * weeksPerYear;
            Console.WriteLine(product2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?"); // making the final compairison after getting all the data from our user. We then print the rtesults out to the screen and our program will exit
            bool trueOrFalse = product1 > product2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
