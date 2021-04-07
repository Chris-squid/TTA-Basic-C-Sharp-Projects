using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //print the current date and time to the console.
            DateTime currentDateTime = DateTime.Now;// here we are gettig the current dateTime by using the .Now .we can accsess many attributes of DateTime
            Console.WriteLine("Current date and time: " + currentDateTime);// printing to the console, current date and time
            //ask user to enter a number.
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            //print the exact time it will be in X hours, X being the number enterd by our user.
            DateTime futureDateTime = currentDateTime.AddHours(Convert.ToInt32(number));
            Console.WriteLine(number + " hours from now it will be " + futureDateTime);
            Console.ReadLine();
        }
    }
}
