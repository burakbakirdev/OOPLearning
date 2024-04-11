// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Init Only properties sayesinde hem objemiz ilk degerini alabiliyor hem de readonly olarak tanimlanabiliyor.
// Yani getter-only properties'den farkli olarak object initiliazer esnasinda deger atanabiliyor.

MyClass myClass = new MyClass 
{ 
    MyProperty = "World" 
};

// myClass.MyProperty = "World"; // Error

record MyRecord
{
    public int MyProperty { get; init; } 
}

class MyClass
{
    readonly int a;
    public int A
    {
        get
        {
            return a;
        }
        init
        {
            a = value;
        }
    }
    public string MyProperty { get; init; } = "Hello";
}