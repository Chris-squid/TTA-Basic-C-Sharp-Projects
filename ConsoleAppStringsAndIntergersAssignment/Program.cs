using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntergersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.

            List<int> numbers = new List<int>() { 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("Pick a number.");
            string userNumber = Console.ReadLine();
            Console.WriteLine("We will now divide the list numbers of 50, 60, 70, 80, 90, 100 by your number.");
            Console.WriteLine();
            try
            {
                foreach (int number in numbers) // we can use the try/catch to display helpful tips and information to the user, it is helpful when making programs.
                {
                    int userNumber2 = Convert.ToInt32(userNumber);
                    int number3 = number / userNumber2;
                    Console.WriteLine(number + " divided by " + userNumber + " equals " + number3);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");

            }
            catch (DivideByZeroException ex) //ex is what we will use to display and Exceptions that we have in ur program. Its helpful to both the programers and the users.
            {
                Console.WriteLine("Do not divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); // we use the finally to make sure our messeges get printed should we encounter any unexpected errors
            }
            Console.WriteLine("Program has exited try/catch block.");
            Console.WriteLine("Thank you for participating.");
            Console.ReadLine();
        }
    }
}
