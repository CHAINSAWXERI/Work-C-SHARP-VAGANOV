namespace ClassLibrary1;

public class CatExeption : ArgumentException
{
    public CatExeption(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}