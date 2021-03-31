using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee(); // create an instance of a class, call methods, objects.
            n.Id = 1001;

            Employee n1 = new Employee();
            n1.Id = 1001;

            Console.WriteLine(n == n1); //print results, making compairison with == operator
            Console.ReadLine(); // allows us to read the results being printed to the console
        }
    }
}
