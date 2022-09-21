using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        static void Main(string[] args)
        {
            // PART A-2
            int number = Input.ReadInteger("Enter a number from 0 to 10:", 0, 10);            
            Console.WriteLine();

            //.

            // PART A-3
            string make = string.Empty;
            Input.ReadString("What is the Make of your car?", ref make);

            Console.WriteLine();

            // PART A-4
            int myChoice = 0;

            string[] tochoose = new string[] { " 1. Consultation", " 2. Appointment", " 3. Walk-In" };
            while (true)
            {
                Input.ReadChoice("Please select an option: ", tochoose, out myChoice);

                switch (myChoice)
                {
                    case 1:
                        Console.WriteLine("You Selected: Consultation\n");
                        break;
                    case 2:
                        Console.WriteLine("You Selected: Appointment\n");
                        break;
                    case 3:
                        return;
                        break;
                }
                {
                    Console.Write(" Press any key to continue ");

                    String keepgoing = Console.ReadLine();

                    Console.WriteLine();
                }
                static string GetSpeech()
            {
                string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream.It is a dream deeply rooted in the American dream. " + "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " + "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " + "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " + "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " + "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " + "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " + "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope.With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " + "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " + "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " + "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire.Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " + "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia!" + "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi.From every mountainside, let freedom ring. " + "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!"; 
                return text;
        }

                //PART B-1
                string text = GetSpeech();
                List<string> wordList = new List<string>(words);
                
                //PART C-1
                Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

                for (int i = 0; i < words.Length; i++)
                {
                    if (dictionary.ContainsKey(words[i]))
                    {
                        dictionary[words[i]]++;
                    }
                    else
                    {
                        dictionary.Add(words[i], 1);
                    }
                }
                Console.WriteLine();
                // PART A-5

                int menuChoice = 0;
                string[] mainMenu = new string[] {"1.The Speech", "2.List of Words", "3.Show Histogram", "4.Search for Word", "5.Remove Word", "6.Exit"};
                while (menuChoice != mainMenu.Length)
                {
                    Input.ReadChoice("Please select an option: ", mainMenu, out menuChoice);

                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("\nYou Selected: The Speech ");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(text);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("\nYou Selected: List of Words");
                            Console.ReadLine();
                            Console.Clear();

                            for (int i = 0; i < wordList.Count; i++)
                            {
                                Console.WriteLine(wordList[i]);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            //PART C-2
                            Console.WriteLine("\nYou Selected: Show Histogram");
                            Console.WriteLine();
                            foreach (KeyValuePair<string, int> show in dictionary)
                            {
                                string key = show.Key;
                                Console.Write($"{show.Key}:");
                                Console.CursorLeft = 15;
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                int value = show.Value;
                                for (int v = 0; v < show.Value; v++)
                                {
                                    Console.Write(" ");
                                }
                                Console.ResetColor();
                                Console.WriteLine($"{show.Value}:");
                            }
                            break;
                        case 4:
                            //PART C-3
                            Console.WriteLine("\nYou Selected: Search for Word");
                            string find = "";
                            Input.ReadString("\nWhat word do you want to find? ", ref find);

                            if (dictionary.ContainsKey(find))
                            {
                                Console.CursorLeft = 9;
                                Console.Write(find);
                                Console.CursorLeft = 15;
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                for (int i = 0; i < dictionary[find]; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.ResetColor();
                                Console.WriteLine(dictionary[find]);
                                Console.WriteLine();
                                //PART C- 4
                                string[] sentences = text.Split(new char[] {'.', '!', '?', ','});

                                for (int i = 0; i < sentences.Length; i++)
                                {
                                    char[] delimiters = new char[] { '.', ' ', ',', '!', '?', };
                                    string[] wordsArray = sentences[i].Split(delimiters,
                                    StringSplitOptions.RemoveEmptyEntries);
                                    for (int w = 0; w < wordsArray.Length; w++)
                                    {
                                        if (wordsArray[w].ToLower().CompareTo(find.ToLower()) == 0)
                                        {
                                            Console.WriteLine(sentences[i]);
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{find} is not Found");
                            }
                            break;
                        case 5:
                            //PART C-5
                            Console.WriteLine("\nYou Selected: Remove Word");
                            string word = "";
                            Input.ReadString("\nEnter the Word to Remove: ", ref word);
                            bool removed = dictionary.Remove(word);
                            if (removed)
                            {
                                Console.WriteLine($"{word} has been removed");
                            }
                            else
                            {
                                Console.WriteLine($"{word} is not Found");
                            }
                            break;
                        default: continue;
                        case 6:
                            return;
                    }
                    Console.WriteLine();
                }
                Console.Write("\n Press any key to continue ");
                string entry = Console.ReadLine();
                Console.Clear();
            }
            

    }
}
}