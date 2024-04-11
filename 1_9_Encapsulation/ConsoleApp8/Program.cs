// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


MyClass m = new MyClass();
m.ASet(10);
Console.WriteLine(m.AGet());



class MyClass
{
    private int a;
    int b; // default is private
    #region Eski usul 
    public int AGet()
    {
        return this.a;
    }

    public void ASet(int value)
    {
        this.a = value;
    }
    #endregion

    #region Yeni usul property ile kullanmak.
    public int Yasi { get; set; }
    #endregion

    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


}