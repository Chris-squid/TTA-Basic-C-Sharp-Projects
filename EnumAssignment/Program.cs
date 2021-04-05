using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");//prompt user to enter day of the week
            string day = Console.ReadLine();

            try //Wrap in try/catch block, print to console error message if error occurs
            {
                daysOfTheWeek days = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day); // Assign the value/values to the variable of the enum data type
                Console.WriteLine("Today's day is {0}", day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }



        }
        enum daysOfTheWeek //Create enum for days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
