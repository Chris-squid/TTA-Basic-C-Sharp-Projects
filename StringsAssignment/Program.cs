using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate 3 strings
            string word = "c#";
            word += " string";
            word += " examples.\n";
            Console.WriteLine(word);


            //Convert String to upper case
            string upperword = word.ToUpper();
            Console.WriteLine(upperword);


            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder create = new StringBuilder();
            create.AppendLine("Welcome To My C# Stings Example");
            create.AppendLine("In this example we will learn how to use a string builder");
            create.AppendLine("We can also append strings on the same line of code").AppendLine("This is an example");
            Console.Write(create);

            Console.ReadLine();
        }
    }
}
