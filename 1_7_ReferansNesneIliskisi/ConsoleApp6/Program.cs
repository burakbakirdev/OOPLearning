// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



MyClass m1 = new MyClass() // Default olarak field ve property'lerin degerlerini atadik.
{
    a = 5,
    Adi = "Ali",
    Yasi = 25
};



class MyClass
{
    public int a;
    public int Yasi { get; set; }
    public string Adi { get; set; }
}