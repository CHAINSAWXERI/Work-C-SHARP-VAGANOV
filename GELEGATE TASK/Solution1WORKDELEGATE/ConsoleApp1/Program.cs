delegate void Del();
delegate void Del2();

class MyClassDel
{
    static void Main(String[] args)
    {
        Del del = MyClass.Hello;
        del += MyClass.Goodbye;

        Del2 del2 = MyClass2.Lol;
        del2 += MyClass2.Yey;
        Del2 del3 = MyClass2.Koo;

        Del2 del0 = del2 + del3;
        
        del3.Invoke();
    } 
}

class MyClass
{
    public static void Hello()
    {
        Console.WriteLine("Hello");
    }
    
    public static void Goodbye()
    {
        Console.WriteLine("Goodbye");
    }
}

class MyClass2
{
    public static void Lol()
    {
        Console.WriteLine("Lol");
    }
    
    public static void Yey()
    {
        Console.WriteLine("yey");
    }
    
    public static void Koo()
    {
        Console.WriteLine("Koo");
    }
}
