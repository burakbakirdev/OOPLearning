// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person person = new Person { Name = "John", Age = 30 };

var (name, age) = person;

Console.WriteLine(name + age);


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}