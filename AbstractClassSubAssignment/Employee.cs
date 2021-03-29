using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssignment
{
    public class Employee : Person, IQuittable
    {
        public Employee()
        {
            firstName = "Sample ";
            lastName = "Student ";
        }

        public void Quit()
        {
            Console.WriteLine("The above employee is quiting the job today.");
            Console.ReadLine();
        }
    }
}
