// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyClass m1 = new MyClass(); // Nesne olusturduk ve ona ulasabilmek icin m1 adinda bir referans olusturduk.
//MyClass m2 = new MyClass();

m1[0] = 10;

Console.WriteLine(m1[0]);
//m1.a = 10;
//m2.a = 20; 

class MyClass
{
    // Field class icerisindeki degiskenler icin kullanilir.
    int yasi;

    // Full Property
    //public int Yasi
    //{
    //    get // property degerini okumak icin kullanilir.
    //    {
    //        return yasi;
    //    }
    //    set
    //    {
    //        yasi = value;
    //    }
    //}

    public int Yasi { get; set; } // Auto Property. Arka planda bir field olusturur ve ona deger atar. Hatta field adi yasi olur.

    public string Adi { get; set; } = "Burak"; // Auto Property. Initial deger atamasi yapabiliriz.

    public string Cinsiyet => "Erkek"; // Expression Body Property. Sadece get oldugu icin sadece okunabilir.

    #region Indexer

    private int[] dizi = new int[10];   
    public int this[int a]
    {
        get
        {
            return dizi[a];
        }
        set
        {
            dizi[a] = value;
        }
    }
    #endregion
}