
//new MyClass();
//new MyClass();

var database1 = Database.GetInstance;
var database2 = Database.GetInstance;
var database3 = Database.GetInstance;

database1.ConnectionString = "connection string 1";
Console.WriteLine(database2.ConnectionString);

#region Singleton Desigh Pattern
// Bir siniftan uygulama bazinda sade ve sadece tek bir nesne olusturulmasini saglayan design pattern'dir.

class Database
{
    Database()
    {
        Console.WriteLine("database created");
    }

    public string ConnectionString { get; set; }
    static Database database;

    static public Database GetInstance
    {
        get
        {
            return database;
        }
    }

    static Database()
    {
        database = new Database();
    }


}
#endregion

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor");
    }

    public MyClass(int i)
    {
        Console.WriteLine("Constructor with parameter");
    }

    static MyClass()
    {
        Console.WriteLine("Static Constructor");
    }

}