// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//MyClass myClass = new MyClass();

MyClass2 myClass2 = new("burak", "bakir");




class MyClass
{
    public MyClass(int a)
    {
        Console.WriteLine("Constructor");
    }

    public MyClass(string name)
    {
        Console.WriteLine($"Constructor with parameter: {name}");
    }

    MyClass()
    {
        
    }
}

class MyClass2
{
    public MyClass2()
    {
        Console.WriteLine("Constructor");
    }
    public MyClass2(string name) : this() // bu sekilde constructor chaining yapabiliriz. Dolayisiyla oncelikle parametresiz constructor calisir.
    {
        Console.WriteLine($"Constructor with parameter: {name}");
    }

    public MyClass2(string name, string surname) : this(name) // parametre verildigi icin 2. constructor'a gidecek ve oradanda 1. constructor'a gidecek.
    {
        Console.WriteLine($"Constructor with parameter: {name} {surname}");

    }

    public void X()
    {

    }
}