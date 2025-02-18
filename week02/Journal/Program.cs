using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:" +
                        "\n1. Write" +
                        "\n2. Display" +
                        "\n3. Load" +
                        "\n4. Save" +
                        "\n5. Quit");
            choice = Console.ReadLine();

            if (choice == "1") //Write
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Prompt: " + prompt);

                Console.Write("Write your entry: ");
                string entryContent = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry.CreateNewEntry(DateTime.Now.Date, prompt, entryContent);

                Console.Write("Do you want to save this? (y/n): ");
                string save = Console.ReadLine().ToLower();

                while (save != "y" && save != "n" && save != "yes" && save != "no")
                {
                    Console.WriteLine("Sorry that's not an option, please enter 'yes' or 'no' (y/n)");
                    save = Console.ReadLine().ToLower();
                }
                if (save == "y" || save == "yes")
                {
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved");
                }
                else if (save == "n" || save == "no")
                {
                    Console.WriteLine("Entry discarded");
                }

                Console.WriteLine();
                
            }
            else if (choice == "2") //Display
            {
                Console.WriteLine("----------------------------------------------");
                journal.DisplayEntries();
                Console.WriteLine();
            }
            else if (choice == "3") //Load
            {
                journal.Load();
                Console.WriteLine();
            }
            else if (choice == "4") //Save
            { 
                journal.Save();
                Console.WriteLine();
            }
            else if (choice == "5") //Quit
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("That number doesn't correspond to any option");
            }        
        }
    }
}