using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1 { 
    class Class1 
    {        
        // Namespace uzerinden erisilebilir. 
    }
}

class OrnekModel
{
    public int a; // class icindeki degerlere field denir. Yani daha sonrasinda objeler tarafindan deger assign edilecek yerlerdir.
    public int b;
    
    public void X()
    {
        Console.WriteLine(a + " " + b);
    }
    public int Y()
    {return a * b;}
}
class MyClass2
{
    // namespace farketmeksizin erisilebilir.
}