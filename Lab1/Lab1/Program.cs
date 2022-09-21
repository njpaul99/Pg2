using System;
using System.Runtime.CompilerServices;
using PG2Input;

namespace Lab1
{

    //
    //------------Lab Notes-------------
    //      Add your Read methods to the Input.cs file in the PG2Input project.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {

        // PART A-2 
        public static int ReadInteger(string prompt, int min, int max)
        {
            bool valid = false;
            int num = 0;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("That is not a number. Please try again");
                    Console.WriteLine();
                }
                else if (number >= min && number <= max)
                {
                    return number;
                }
                else
                {
                    valid = false;
                }
            }
            return num;
        }
        // PART A-3 - ReadString
        public static void ReadString(string prompt, ref string value)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                value = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    break;
                }
            }
        }
        // PART A-4
        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            selection = ReadInteger(prompt, 1, options.Length);
        }
       
    }
}

