using System.Text.Json;

class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person()
        {
            Name = "Jack",
            Surname = "Jones",
            Age = 38,
            Birthday = new DateTime(1983, 01, 16)
        };
        string personJson = JsonSerializer.Serialize(person,
        typeof(Person));
        StreamWriter file = File.CreateText("person.json");
        file.WriteLine(personJson);
        file.Close();

    }
}

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public DateTime Birthday { get; set; }
}