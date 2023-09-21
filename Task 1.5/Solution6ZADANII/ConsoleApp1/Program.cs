using ClassLibrary1;

static void Main(string[] args)
{


    Book<int> Book1 = new Book<int>(1000, "book1", "Autor1", 300);
    Book<int> Book2 = new Book<int>(2000, "book2", "Autor1", 700);
    Book<string> Book3 = new Book<string>("uku", "book3", "Autor1", 900);
    Book<string> Book4 = new Book<string>("kuk", "book4", "Autor1", 80);
    Book<Guid> Book5 = new Book<Guid>(new Guid(), "book5", "Autor1", 3000);
    Book<Guid> Book6 = new Book<Guid>(new Guid(), "book6", "Autor1", 20);


    Book1.ToString();
    Book2.ToString();
    Book3.ToString();
    Book4.ToString();
    Book5.ToString();
    Book6.ToString();
}