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
                    string escapedContent = entry._content.Replace("\"", "\"\"");
                    writer.WriteLine($"{entry._date.ToString("yyyy-MM-dd")}, \"{escapedPrompt}\", \"{escapedContent}\"");
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
        Console.WriteLine("I don't know how to Load a journal from a file");
    }

}