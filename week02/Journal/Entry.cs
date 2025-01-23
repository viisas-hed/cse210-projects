public class Entry 
{
    public DateTime _date ;
    public string _prompt ;
    public string _content ;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - {_prompt}") ;
        Console.WriteLine() ;
        Console.WriteLine(_content) ;
    }
}
