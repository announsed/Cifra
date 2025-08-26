internal static class Program
{
    public static List<User> users = new List<User>();
    private static void Main(string[] args)
    {
        bool isStart = true;
        ConvertArrayInListAndAdd();
        while (isStart)
        {
            UserFileAndProgram.Menu();
            Console.Write(" \n Ввод: ");
            isStart = Action(isStart);
        }
    }







    static bool Action(bool isStart)
    {
        switch (Console.ReadLine())
        {
            case "1" or "1)":
                Console.Write(" Введите имя: ");
                string userInputName = Console.ReadLine();
                Console.Write(" Введите логин: ");
                string userInputLogin = Console.ReadLine();
                Console.Write(" Введите пароль: ");
                string userInputPassword = Console.ReadLine();
                bool hasLogin = false;
                for (int j = 0; j < Program.users.Count; j++)
                {
                    if (Program.users[j].Login == userInputLogin)
                    {
                        Console.WriteLine($" Пользователь с логином {userInputLogin} уже существует в системе");
                        hasLogin = true;
                        break;
                    }
                }
                if (!hasLogin)
                {
                    new User(userInputName, userInputLogin, userInputPassword);
                }

                break;

            case "2" or "2)":
                if (users.Count == 0)
                {
                    Console.WriteLine("\n Список пуст! \n");
                }
                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine($" {users[i].Id} {users[i].Name} {users[i].Login} {users[i].Password}");
                }

                break;

            case "3" or "3)":
                Console.Write("\n Введи Id пользователя для удаления: ");
                int userInputId = Convert.ToInt32(Console.ReadLine());
                bool isIdUser = false;
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Id == userInputId)
                    {
                        users.RemoveAt(i);
                        string[] saveInArray = new string[users.Count];
                        for (int j = 0; j < saveInArray.Length; j++)
                        {
                            saveInArray[j] = $"{users[j].Id} {users[j].Name} {users[j].Login} {users[j].Password}";
                        }
                        Console.WriteLine(" Пользователь удален!");
                        File.WriteAllLines("userData.txt", saveInArray);
                        isIdUser = true;
                        break;
                    }
                }
                if (!isIdUser)
                {
                    Console.WriteLine($" Нет такого Id {userInputId} для удаления");
                }
                if (users.Count == 0)
                {
                    Console.WriteLine("\n Нет пользователей для удаления!");
                }
                break;

            case "4" or "4)":
                isStart = false;
                break;

            default:
                Console.WriteLine("\n Не понял что это ты ввел!");
                break;
        }
        return isStart;
    }

    static void ConvertArrayInListAndAdd()
    {
        string[] hash = UserFileAndProgram.GetData();
        if (hash.Length != 0)
        {
            for (int i = 0; i < hash.Length; i++)
            {
                string[] hashArray = hash[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (hashArray == null || hashArray.Length == 0)
                {
                    continue;
                }
                else
                {
                    int hashId = Convert.ToInt32(hashArray[0]);
                    User newUser = new User(hashArray[1], hashArray[2], hashArray[3], hashId);
                }
            }
        }
    }
}

internal static class UserFileAndProgram
{

    internal static void SaveData(string saveString)
    {
        string[] arr = GetData();
        if (arr.Length == 0)
        {
            File.AppendAllText("userData.txt", saveString);
        }
        else
        {
            File.AppendAllText("userData.txt", "\n" + saveString);
        }
    }
    internal static string[] GetData()
    {
        if (!File.Exists("userData.txt"))
        {
            return Array.Empty<string>();
        }
        return File.ReadAllLines("userData.txt");
    }

    internal static IsDataExists isDataExists = (string stringData) =>
    {
        return stringData ?? throw new Exception("Нет данных");
    };

    internal static void Menu()
    {
        string[] menu = new string[]
        {  " 1) Добавить пользователя",
           " 2) Посмотреть список пользователей",
           " 3) Удалить пользователя",
           " 4) Выход из программы"
        };

        foreach (var item in menu)
        {
            Console.WriteLine(item);
        }
    }
}

public delegate string IsDataExists(string stringData);

public interface IUser
{
    internal int Id { get; set; }
    internal string Name { get; set; }
    internal string Login { get; set; }
    internal string Password { get; set; }
}

class User : IUser
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }



    public User(string Name, string Login, string Password)
    {
        this.Name = UserFileAndProgram.isDataExists(Name);
        this.Login = UserFileAndProgram.isDataExists(Login);
        this.Password = UserFileAndProgram.isDataExists(Password);
        int count = Program.users.Count;
        this.Id = count++;
        string saveString = $"{this.Id} {this.Name} {this.Login} {this.Password}";
        UserFileAndProgram.SaveData(saveString);
        Program.users.Add(this);
    }
    public User(string Name, string Login, string Password, int Id)
    {
        this.Name = UserFileAndProgram.isDataExists(Name);
        this.Login = UserFileAndProgram.isDataExists(Login);
        this.Password = UserFileAndProgram.isDataExists(Password);
        this.Id = Id;
        string saveString = $"{this.Id} {this.Name} {this.Login} {this.Password}";
        Program.users.Add(this);
    }
}

