/*
Program - week9Assignment
Programer - Toby Cantello
Date Created - 3/25/2022
Last Date Updated - 3/30/2022
*/

using System;
using System.Text.RegularExpressions;
using System.IO;

namespace week9Assignment
{
    class Program
    {
        private static string readText;

        static bool UserPath(out string validInput, string userInput)
        {
            validInput = null;
            var pathChecker = new Regex(@"(^[a-zA-Z]:/)|(\.txt+$)|(\.TXT$)");

            if (pathChecker.IsMatch(userInput))
            {
                Console.WriteLine("File path is vaild");
            }
            else
            {
                Console.WriteLine("You didn't enter a path to a text file");
                return false;
            }

            return true;
        }

        public static void ReadFile(string input)
        {
            try
            {
                StreamReader sr = new StreamReader(input);
                readText = sr.ReadToEnd();  
                Console.WriteLine("Opening the file...");
                Console.WriteLine();
                Console.WriteLine(readText);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unfortunately, the file does not exist.");
            }
        }
        static void WordCount(string input)
        {
            if (input == null)
            {
                return;
            }
            else
            {
                int wordCount = input.Split(' ').Length;
                Console.WriteLine("There are " + wordCount + " words in the file.");
            }
        }
        static void Main(string[] args)
        {
            string userInput = "";

            Console.WriteLine("Please enter the path to the text file you want to open.");
            userInput = @"" + Console.ReadLine();
            Console.WriteLine();

            if(UserPath(out string validInput, userInput))
            {
                ReadFile(userInput);
                WordCount(readText);
            }
        }
    }
}
