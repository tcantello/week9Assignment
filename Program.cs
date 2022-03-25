/*
Program - week9Assignment
Programer - Toby Cantello
Date Created - 3/25/2022
Last Date Updated - 3/25/2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace week9Assignment
{

    class Program
    { 
        static bool UserInput(out string userInput)
        {

            Console.WriteLine("Please enter the path to the text file you want to open.");
            userInput = Console.ReadLine();

            // regex checking

            // if regex is match
            return true;
        }
        static void ReadFile(string input)
        {
            var sr = new StreamReader(input);
            Console.WriteLine(sr.ReadLine());
        }   

        static void Main(string[] args)
        {
            string input = "";
            if(UserInput(out input))
            { 
                ReadFile(input); 
            }


        }
    }
}
