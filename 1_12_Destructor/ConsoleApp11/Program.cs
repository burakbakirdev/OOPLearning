// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

X();
GC.Collect();
Console.ReadLine();

static void X()
{
MyClass obj = new MyClass();

}


class MyClass
{

    public MyClass()
    {
        Console.WriteLine("Constructor is called");
    }

    ~MyClass()
    {
        Console.WriteLine("Destructor is called");
    }

}