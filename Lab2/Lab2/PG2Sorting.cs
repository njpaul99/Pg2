using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab2
{
    public static class PG2Sorting
    {
        private static void BubbleSort(List<string> sortedCopy)
        {
            throw new NotImplementedException();
        }
        static void Serialize(List<string>unsorted)
        {
            List<string> sortedCopy = unsorted.ToList();
            BubbleSort(sortedCopy);
            filepath = Path.ChangeExtension(filepath, ".json");
            using(StreamWriter sw = new StreamWriter(filepath))
            {
                using(JsonTextWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, sortedCopy);
                }
            }
        }
        
            {
            ReadChoice("Please select an option:", MainMenu, out choice);
            Console.Clear();
            Switch(choice)
        {
            //1
            Console.WriteLine("Bubble Sort");
            Console.Write(". . .");
            Console.WriteLine();

            List<string> loading = LoadFile(filepath);
            List<string> toshort = BubbleSort(loading);
            for (int i = 0; i < toshort.Count; i++)
            {
                Console.Write(loading[i]);
                Console.CursorLeft = 70;
                Console.WriteLine(toshort[i]);
            }

            //2
            Console.WriteLine("Merge Sort");
            Console.Write(". . .");
            Console.WriteLine();

            List<string> notsorted = LoadFile(filepath);
            List<string> willsort = BubbleSort(notsorted);
            for (int i = 0; i <= willsort.Count; i++)
            {
                Console.Write(notsorted[i]);
                Console.CursorLeft = 70;
                Console.WriteLine(willsort[i]);
            }

            //3
            Console.WriteLine("Binary Search");
            Console.Write(". . .");
            Console.WriteLine();

            List<string> original = LoadFile(filepath);
            List<string> sorted = BubbleSort(original);

            string search = string.Empty;

            for (int i = 0; i < sorted.Count; i++)
            {
                var foundindex = BinarySearch(sorted, search);
                Console.Write(sorted[i]);
                int index = sorted.IndexOf(sorted[i]);
                Console.CursorLeft = 50;
                Console.Write("Index: {i}");
                Console.CursorLeft = 90;
                Console.WriteLine("Found Index: {Index}");
            }

            //4
            Console.WriteLine("Save");
            Console.Write(". . .");
            Console.WriteLine();

            String file = "";
            ReadString("Enter File Name to Save: ", ref file);

            List<string> unSorted = LoadFile(filepath);
            BubbleSort(unSorted);
            for(int i = 0; i < unSorted.Count; i++)
            {
                Console.Write(unSorted[i]);
                Console.CursorLeft = 70;
                Console.WriteLine(unSorted[i]);
            }
            Serialize(BubbleSort(unSorted));

           // break;

            //5
            Console.WriteLine("Exit");
            return;
            Console.WriteLine("You did not make a valid selection");
        }
        Console.Write("Press any key to continue..."); 
        String keepgoing = Console.ReadLine();
        private static string filepath;

        Console.WriteLine();
    }
}
