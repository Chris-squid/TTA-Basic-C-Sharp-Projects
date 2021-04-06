using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> n = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Smith", ID = 001 },
                new Employee() {FirstName = "Chris", LastName = "Robinson", ID = 002 },
                new Employee() {FirstName = "Joe", LastName = "Williams", ID = 003 },
                new Employee() {FirstName = "Kelly", LastName = "Jones", ID = 004 },
                new Employee() {FirstName = "Marty", LastName = "Brown", ID = 005 },
                new Employee() {FirstName = "Jim", LastName = "Davis", ID = 006 },
                new Employee() {FirstName = "Frank", LastName = "Miller", ID = 007 },
                new Employee() {FirstName = "Connie", LastName = "Wilson", ID = 008 },
                new Employee() {FirstName = "Angus", LastName = "Young", ID = 009 },
                new Employee() {FirstName = "Phil", LastName = "Sparks", ID = 010 }
            };

            List<Employee> m = new List<Employee>();

            foreach (Employee employee in n)// use foreach loop, create a new list of all employees with first name "Joe"
            {
                if (employee.FirstName == "Joe")
                {
                    m.Add(employee);

                }
            }

            List<Employee> p = n.Where(x => x.FirstName == "Joe").ToList();//Do the same thing again, with Lambda expression

            List<Employee> q = n.Where(x => x.ID > 5).ToList();// Lambda expression, make list where all employee ID greater thasn 5

            Console.WriteLine(n.Count);
            Console.WriteLine(m.Count);
            Console.WriteLine(p.Count);
            Console.WriteLine(q.Count);

            Console.ReadLine();
        }
    }
}
