// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class MyClass
{
    int a;

    public void X(int a)
    {
        a = a; // Bu durumda a parametresi a'ya esitlenir. Yani a = a; olur. Bu durumda class icerisindeki a hicbir degisiklik olmaz.
        this.a = a; // this. ile class icerisindeki a'ya erisiriz. Bu durumda class icerisindeki a'ya parametredeki a degeri atanir.
    }
}