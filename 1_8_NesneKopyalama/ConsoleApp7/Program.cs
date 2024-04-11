// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 5;
int b = a; // a'nin degerini b'ye kopyaladik. Yani stack'te b ye a'nin degerini kopyaladik. Buna deep copy denir.

#region Shallow Copy : Ayni nesneyi baska bir referans ile isaretlemeye denir. Yeni bir nesne olusmaz.
MyClass m1 = new MyClass();
MyClass m2 = m1;
MyClass m3 = m2;
MyClass m4 = new MyClass();
#endregion

// Eger bir referansi baska bir nesneye referans ettirirsek eski referansi ile iliskisi kesilir.

#region Deep Copy : Nesnenin kopyasini olusturur. Yani yeni bir nesne olusturur.    
MyClass m5 = new MyClass();
MyClass m6 = m1; // Shallow Copy
MyClass m7 = m1.Clone(); // Deep Copy
#endregion


class MyClass
{
    public MyClass Clone()
    {
        return (MyClass)this.MemberwiseClone();
    }
}