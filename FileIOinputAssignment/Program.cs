using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIOinputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to input a number
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();

            //log number to a txt file.
            File.WriteAllText(@"C:\Users\15039\Onedrive\Documents\GItHub\Basic_C#_Programs\log.txt", number);
            //print text file back to user.
            string readText = File.ReadAllText(@"C:\Users\15039\Onedrive\Documents\GItHub\Basic_C#_Programs\log.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
