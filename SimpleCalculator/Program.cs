using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string someText = "Here is Some text";
            string someOtherText = "Here is some text";


            bool isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);

            //String Concatenation
            string addedText = someText + " " + someOtherText + "Here is some more text.";
            //String Formatting 
            string formattedString = string.Format("{0} {1} here is some more text", someText, someOtherText);

            Console.WriteLine(formattedString);

            //String Length and Index
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]); 

            //Substring
            Console.WriteLine(someText.Substring(8,4));

            //Lower Case and UpperCase
            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());

            string anotherText = "";
            //instead of doing the above use empty strings
            string anotherText2 = string.Empty;

            //do not use string literals in your code but rather store it 
            //in a variable and use the variables all round your code

            //Replacing strings
            string replacedText = someText.Replace("text", "string");
            Console.WriteLine(replacedText);




            ////////////////////////////////////////////////////
            /// CONDITIONAL STATEMENTS
            ////////////////////////////////////////////////////

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username.Equals("Avetis") && password.Equals("abc124"))
            {
                Console.WriteLine("Hello Admin");
            }
            else if (username.Equals("Joe") && password.Equals("abc124"))
            {
                Console.WriteLine("Hello Moderator");
            }
            else
            {
                Console.WriteLine("Hello Guest");
            }

            //Using switch Statements
            switch (username)
            {
                case "Avetis":
                    Console.WriteLine("Hello Admin");
                    break;
                case "Joe":
                    Console.WriteLine("Hello Moderator");
                    break;
                default:
                    Console.WriteLine("Hello Guest");
                    break;
            }*/
            
             //Exception class
            Exception myFirstException = new Exception();
            try
            {
                string input = Console.ReadLine();

                try
                {
                    StringToIntConverter stringtointconverter = new StringToIntConverter();
                    stringtointconverter.convert(input);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("There was an Error with conversion: {0}", ex.Message); ;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an Error: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("The rest of my application is still running");
            }
            
            
            Person person1 = new Person();
            Console.WriteLine(person1.getAge());
            person1.setAge(29);
            Console.WriteLine(person1.getAge());

            Person.greet();
         }
    }
}