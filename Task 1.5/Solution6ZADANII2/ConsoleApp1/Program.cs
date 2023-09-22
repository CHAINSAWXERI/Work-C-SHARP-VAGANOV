using ClassLibrary1;

static void Main(string[] args)
{
    Book<int> Book1 = new Book<int>(1000, "book1", "Autor1", 300);
    Kucha<int> Obj1 = new Kucha<int>(300);
    Kucha<Book<int>> Obj2 = new Kucha<Book<int>>(Book1);
    Console.WriteLine(Obj1);
    Console.WriteLine(Obj2);
    Obj1.Reset();
    Obj2.Reset();
    Console.WriteLine(Obj1);
    Console.WriteLine(Obj2);
}