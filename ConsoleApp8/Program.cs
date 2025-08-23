using System.Security.Cryptography.X509Certificates;

Random random = new Random();
int[] array = new int[20];
Console.WriteLine(" Начальный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-100, 101);
    Console.Write( array[i]  + ", ");
}

Console.WriteLine("\n");

int[] массив = array.Where(x => x % 2 == 0).ToArray();
Console.WriteLine(" Отсортированный массив: ");
foreach (var item in массив)
{
    Console.Write(item + ", ");
}


Console.WriteLine("\n\n");


List<DateTime> dateTimes = new List<DateTime>() {new DateTime(1996, 3, 2), new DateTime(2056, 11, 30), new DateTime(2077, 3,6) };
Console.WriteLine(" Начальные даты: ");
foreach (var item in dateTimes)
{
    Console.Write(item + "; ");
}

Console.WriteLine("\n");

dateTimes = dateTimes.Where(x => x > DateTime.Now).ToList();
Console.WriteLine(" Будующие даты: ");
foreach (var item in dateTimes)
{
    Console.Write(item + ", ");
}


Console.WriteLine("\n\n");


string[] stringsArray = {"слово1", "случайное", "экзотический", "лаунчер", "лужа", "шар"};
Console.WriteLine(" Массив со словами");
foreach (var item in stringsArray)
{
    Console.Write(item + ", ");
}

Console.WriteLine("\n");

Console.WriteLine("Отсортированный массив: ");

stringsArray = stringsArray.Where(x => x.Length >= 5).ToArray();
foreach (var item in stringsArray) 
{
    Console.Write(item + ", ");
}


Console.WriteLine("\n\n");

List<People> people = new List<People>() {new People("Павел", 12), new People("Афанасий",32), new People("Ника", 56), new People("Никита",31), new People("Лука",45) };

Console.WriteLine(" Полный список людей: ");
foreach (var item in people)
{
    Console.Write("Имя: " + item.Name + " Возраст: " + item.Age + "  ");
}

Console.WriteLine("\n");

people = people.Where(x => x.Age >= 30).ToList();

Console.WriteLine(" Отсортированный список людей: ");
foreach (var item in people)
{
    Console.WriteLine(" Имя: " + item.Name + " Возраст: " + item.Age );
}


class People 
{
    internal string Name { get; set; }
    internal int Age { get; set; }
    public People(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}
