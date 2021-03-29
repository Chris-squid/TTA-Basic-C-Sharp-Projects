using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssignment
{
    public class Person // Create an abstract class with 2 properties: string firstName, lastName.
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            string fullName = firstName + lastName;
            Console.WriteLine("Name: " + fullName);
            Console.ReadLine();
        }
        
    }
}
