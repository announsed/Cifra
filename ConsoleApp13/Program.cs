using System.Text.Encodings.Web;
using System.Text.Json;

Person person = new Person("Паша", "Котов", 22,"ул. Пушкина, д.4а, кв. 921", "pasinto@mail.ru",new (1998, 10, 23));


var options = new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true, // Для читаемости, необязательно
    IncludeFields = true
};

Console.WriteLine($"{person.Name} {person.LastName} {person.Age} {person.Address} {person.Email} {person.DateOfBirth}");
string personJSON = JsonSerializer.Serialize(person, typeof (Person), options);
StreamWriter file = File.CreateText("C:\\Users\\Student\\source\\repos\\Sergey\\Cifra\\ConsoleApp13\\Wuw.json");
file.WriteLine(personJSON);
file.Close();


class Person 
{
    public string Name;
    public string LastName;
    public int Age;
    public string Address;
    public string Email;
    public DateOnly DateOfBirth;
    public Person(string name, string lastName, int age, string address, string mail, DateOnly dateOnly) 
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Address = address;
        Email = mail;
        DateOfBirth = dateOnly;
    }
}