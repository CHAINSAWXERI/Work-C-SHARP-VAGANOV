namespace AbstractClasses_Task2
{
    public abstract class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public abstract string GetInfo();
    }

    public class FictionBook : Book
    {
        public string Genre;

        public FictionBook(string title, string author, int year, string genre) : base(title, author, year)
        {
            Genre = genre;
        }

        public override string GetInfo()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Genre: {Genre}";
        }
    }

    public class ScienceBook : Book
    {
        public string Field;

        public ScienceBook(string title, string author, int year, string field) : base(title, author, year)
        {
            Field = field;
        }

        public override string GetInfo()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Field: {Field}";
        }
    }

    class Program
    {
        static void Main()
        {
            FictionBook fictionBook1 = new FictionBook("To Kill a Mockingbird", "Harper Lee", 1960, "Southern Gothic");
            FictionBook fictionBook2 = new FictionBook("1984", "George Orwell", 1949, "Dystopian");
            ScienceBook scienceBook1 = new ScienceBook("A Brief History of Time", "Stephen Hawking", 1988, "Physics");
            ScienceBook scienceBook2 = new ScienceBook("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", 2011, "Anthropology");

            List<Book> booksCollection = new List<Book> { fictionBook1, fictionBook2, scienceBook1, scienceBook2 };


            for(int i = 0; i < booksCollection.Count; i++)
            {
                Book book = booksCollection[i];
                Console.WriteLine(book.GetInfo());
            }
        }
    }

}