using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cake.Core.IO;
using Newtonsoft.Json;

namespace Lab2
{

    //
    //------------Lab Notes-------------
    //      Add your Sorting and Searching methods to the PG2Sorting.cs file.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "inputfile.csv";

            int choice = 0;
            string[] MainMenu = new string[] { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit" };


            void ReadChoice(string prompt, string[] options, out int selection)
            {
                for (int i = 0; i < MainMenu.Length; i++)
                {
                    Console.WriteLine(MainMenu[i]);
                }
                selection = ReadInteger(prompt, 1, MainMenu.Length);
            }
            int ReadInteger(string prompt, int min, int max)
            {
                bool valid = false;
                int num = 0;
                while (!valid)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("That is not a valid number. Please try again");
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
            void ReadString(string prompt, ref string value)
            {
                bool valid = false;

                while (!valid)
                {
                    Console.WriteLine(prompt);
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
            Console.Clear();
        }
        public static List<string> LoadFile(string filepath)
        {
            char delimiter = '.';

            string title = File.ReadAllText(FilePath);
            string[] data = title.Split(delimiter);
            List<string> comicTitle = new List<string>(data);
            List<string> unsorted = comicTitle.ToList();

            return unsorted;
        }
        public static List<string> BubbleSort(List<string> unsorted)
        {
            List<string> sorted = unsorted.ToList();

            bool swapped = true;
            int n = sorted.Count;
            while (true)
            {
                swapped = false;

                for (int i = 1; i <= n; i++)
                {
                    if (sorted[i - 1].CompareTo(sorted[i]) > 0)
                    {
                        string temp = sorted[i];
                        sorted[i] = sorted[i - 1];
                        sorted[i - 1] = temp;
                        swapped = true;
                    }
                }
                n--;
                if (swapped == false)
                {
                    break;
                }
            }
            return sorted;
        }
        public static List<string> MergeSort(List<string> sorted)
        {
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            if (sorted.Count <= 1)
            {
                for (int i = 0; i < sorted.Count; i++)
                {
                    if (i < (sorted.Count)/2)
                    {
                        left.Add(sorted[i]);
                    }
                    if (i < (sorted.Count)/2)
                    {
                        right.Add(sorted[i]);
                    }
                }
                left = MergeSort(left);
                right = MergeSort(right);
                return MergeSort(left, right);
            }
            return sorted;
        }
        private static List<string> Merge(List<string> left, List<string> right)
        {
            var result = new List<string>();
            int j = 0;
            int k = 0;

            while (left != null && right != null)
            {
                if (left[j].CompareTo(right[j]) <= 0)
                {
                    result.Add(left[j]);
                    left.RemoveAt(j);
                }
                else
                {
                    result.Add(right[k]);
                    right.RemoveAt(k);
                }
            }
            while (left!= null)
            {
                result.Add(result[j]);
                left.RemoveAt(j);
            }
            while (right!= null)
            {
                result.Add(result[k]);
                right.RemoveAt(k);
            }
            return result;
        }
        public static int BinarySearch(List<string> sorted, string ItemToFind, int min, int max)
        {
            List<string> sortedList = sorted.ToList();
            int high = sortedList.Count = -1;
            int foundIndex = -1;
            if (max < min)
            {
                int mid = (high + min) / 2;

                if (sortedList[mid].CompareTo(ItemToFind) > 0)
                {
                    return BinarySearch(sortedList, ItemToFind, min, mid - 1);
                }
                else if (sortedList[mid].CompareTo(ItemToFind) > 0)
                    {
                    return BinarySearch(sorted, ItemToFind, min, mid + 1);
                }
                else
                {
                    return mid;
                }
                return foundIndex;
            }
            public static int BinarySearch(List<string> sorted, string itemToFind, int v)
            {
                return BinarySearch(sorted, itemToFind, 0, sorted.Count - 1);
            }
        }
    }
}
