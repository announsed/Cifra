using System.Drawing;
using System.Reflection.PortableExecutable;

var programmer = new Programmer()
{
    Id = 123,
    Name = "Евгений",
    Adress = "ул. Тонкинская, д.12",
    Gender = Gender.Man,
    Species = Species.Human,
    EyeColor = Color.DarkGreen,
    NumberPhone = "8 (800) 555-35-35",
    Age = 22,
    Post = "Middle",
    DateOfEmployment = new DateTime(2007,5,20)

};
programmer.AddCharacteristic("Любит шаурму");


public enum Gender
{
    Man = 0,
    Woman = 1,
    Other = 2
}
public enum Species
{
    Human = 0,
    Animal = 1,
    Other = 2
}

abstract class People<T>
{
    private List<T> _characteristics = new List<T>();
    public virtual IEnumerable<T> GetCharacteristics() 
    {
        return _characteristics;
    }
    public virtual void AddCharacteristic(T characteristic)
    {
        _characteristics.Add(characteristic);
    }

    public virtual void RemoveCharacteristic(T characteristic)
    {
        _characteristics.Remove(characteristic);
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Species Species { get; set; }
    public Color EyeColor { get; set; }


}

class Person : People<string>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public string Adress { get; set; }
    public string NumberPhone { get; set; }
}

class Employee : Person 
{
    public int Id { get; set; }
    public string Post { get; set; }
    public decimal Salary { get; set; }
    public DateTime DateOfEmployment { get; set; }
}

class Techer : Employee 
{
    public string SubjectThatTeaches { get; set; }
    public int TeachingExperience { get; set; }
}

class Student : Employee 
{
    public int Course { get; set; }
    public string Specialization { get; set; }
    public double AverageScore { get; set; }
}

class Manager : Employee 
{
    public string ManagementArea { get; set; }
    public int NumberOfSubordinates { get; set; }
    public int ManagementExperience { get; set; }
}

class Programmer : Employee 
{
    public string LanguageProgram { get; set; }
    public List<string> Progect { get; set; } = new List<string>();
    public string Specialization { get; set; }
}