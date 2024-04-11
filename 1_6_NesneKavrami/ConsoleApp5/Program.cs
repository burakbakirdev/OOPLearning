// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


new MyClass(); // MyClass class'indan bir nesne olusturduk.

MyClass x = new MyClass(); // MyClass class'indan bir nesne olusturduk ve x adinda bir referans olusturduk.

MyClass y = new(); // Target-yped new expression. C# 9.0 ile gelmistir. 


class MyClass
{
    public int A { get; set; }

    public void X()
    {

    }
}