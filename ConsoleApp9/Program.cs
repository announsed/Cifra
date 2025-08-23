List<User> hash = new List<User> ();

static void SaveData(string[] save)
{
    string path = @"C:\Users\Student\source\repos\Sergey\Cifra\ConsoleApp9\userData.txt";
    File.AppendAllLines(path, save);
}

static string[] ReadData()
{
    string path = @"C:\Users\Student\source\repos\Sergey\Cifra\ConsoleApp9\userData.txt";
    string[] ss = null;
    if (File.Exists(path))
    {
        string[] strings = File.ReadAllLines(path);
        return strings;
    }
    else 
    {
        Console.WriteLine(" Оштбка чтения, файл отсутствует");
    }
    return ss;
}

internal interface IUser
{
    int Id { protected get; set; }
    string Name { protected get; set; }
    string Login { protected get; set; }
    string Password { protected get; set; }
}


class User : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public User(string Name, string Login, string Password)
    {
        this.Name = Name;
        this.Login = Login;
        this.Password = Password;
    }


}

