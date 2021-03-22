using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            do
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }
            while (password != "Pa$$w0rd");

            Console.WriteLine("Correct!");
            Console.ReadLine();
              
        }
    }
}
