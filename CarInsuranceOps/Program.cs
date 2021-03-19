using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//Ask for age verification
            string age = Console.ReadLine();
            int a = Convert.ToInt16(age); 
            Console.WriteLine("Have you ever had a DUI? True or False");// use boolean logic to determine if true or false for results of DUI
            bool trueOrFalse = Console.ReadLine() == "false";
            Console.WriteLine("How many speeding tickets do you have?");// Boolean logic in use again to determine if qualified for Insurance from # of speeding tickets
            string speedingTicket = Console.ReadLine();
            int speedTicket = Convert.ToInt16(speedingTicket);// capture data, compair with our values and data to print results of true of false for user to see if they are able to buy coverage.
            Console.WriteLine("Qualified?");
            bool qualification = a > 15 && trueOrFalse && speedTicket <= 3;
            Console.Write(qualification.ToString());
            Console.ReadLine();
        }
    }
}
