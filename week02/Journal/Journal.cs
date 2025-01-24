using System.Runtime.CompilerServices;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>() ;
    public static string _filePath  ;

    public Journal()
    {
    }

    public void AddEntry(Entry newEntryElement)
    {
        _entries.Add(newEntryElement);
    }

    public void DisplayEntries()    
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else{
            foreach (Entry entry in _entries)
            {
            entry.Display();
            Console.WriteLine("----------------------------------------------");
            }
        }
    }

    public void Save()
    {     
        Console.WriteLine("Enter file path (don't forget to add the extension, like '.csv' or '.txt'): ");
        _filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(_filePath))
        {
            Console.WriteLine("Invalid file path. Operation canceled.");
            return;            
        }

        try
        {
            bool isHeader = false;
            if (System.IO.File.Exists(_filePath))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(_filePath))
                {
                    string firstLine = reader.ReadLine();
                    if (firstLine == "Date, Prompt, Entry")
                    {
                        isHeader = true;
                    }
                }
            }
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@_filePath, true, System.Text.Encoding.UTF8))
            {
                if (isHeader == false)
                {
                    writer.WriteLine("Date, Prompt, Entry");
                }

                foreach (Entry entry in _entries)
                {
                    string escapedPrompt = entry._prompt.Replace("\"", "\"\"");
                    if (escapedPrompt.Contains(",") || escapedPrompt.Contains("\n") || escapedPrompt.Contains("\""))
                    {
                        escapedPrompt = $"\"{escapedPrompt}\"";
                    }

                    string escapedContent = entry._content.Replace("\"", "\"\"");
                    if (escapedContent.Contains(",") || escapedContent.Contains("\n") || escapedContent.Contains("\""))
                    {
                        escapedContent = $"\"{escapedContent}\"";
                    }
                    
                    writer.WriteLine($"{entry._date:yyyy-MM-dd},{escapedPrompt},{escapedContent}");
                }
            }
            _entries.Clear();

            Console.WriteLine("\nJournal saved successfully!");
        }
        catch(Exception ex)
        {
            throw new ApplicationException($"An error occurred: {ex.Message}\n{ex.StackTrace}") ;
        }
        
    }

    public void Load()
    {
        _entries.Clear();
        Console.WriteLine("Enter file path: ");
        _filePath = Console.ReadLine();

        if (!System.IO.File.Exists(_filePath) || String.IsNullOrWhiteSpace(_filePath))
        {
            Console.WriteLine("The specified file does not exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(_filePath);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry.CreateNewEntry(DateTime.Parse(parts[0]),parts[1],parts[2]);
            AddEntry(newEntry); 
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}