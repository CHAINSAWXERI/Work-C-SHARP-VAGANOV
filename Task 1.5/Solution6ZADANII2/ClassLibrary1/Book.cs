namespace ClassLibrary1;

public class Book<T>
{
    public T Id { get;}
    public int PagesCount { get;}
    public string Name { get;}
    public string Author { get;}
    
    public Book(T id, string name, string author, int pagesCount)
    {
        Id = id; 
        Name = name;
        Author = author;
        PagesCount = pagesCount;
    }

    public override string ToString()
    {
        return Id + " " + Name + ", " + Author + ", " + PagesCount + " Страниц";
    }
}