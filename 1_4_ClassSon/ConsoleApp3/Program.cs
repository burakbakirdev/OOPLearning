// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyClass m1 = new MyClass();

m1.Yasi = 10;

MyClass.MyClass2 m2 = new MyClass.MyClass2(); // MyClass icerisindeki MyClass2 classina ulasmak icin bu sekilde kullanilir.

#region Class Elemanlarina Aciklama Satiri nasil eklenir? 


#endregion
/// <summary> 3 adet / koyunca aciklama koymak icin bir summary olusturur. Neyi aciklamak istiyorsak onun basinin ustune yazilir.
/// Bu bir ornek class'tir.
/// </summary>
class MyClass
{   
    /// <summary>
    /// Bu bir property'dir. Adi property olabilir.
    /// </summary>
    public int Yasi { get; set; } // Auto Property. Arka planda bir field olusturur ve ona deger atar. Hatta field adi yasi olur.

    

    public class MyClass2
    {

    }
}