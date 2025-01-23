public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _content;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - {_prompt}");
        Console.WriteLine();
        Console.WriteLine(_content);
    }
    public void CreateNewEntry(DateTime date, string prompt, string entryContent)
    {
        _date = date;
        _prompt = prompt;
        _content = entryContent;
    }
}
