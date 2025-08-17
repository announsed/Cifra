bool isStart = true;
ConvertArrayInListAndAdd();
while (isStart)
{
    UserFileAndProgram.Menu();
    Console.Write(" \n Ввод: ");
    isStart = Action(isStart);
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
            User newUser = new User(userInputName, userInputLogin, userInputPassword);
            UserFileAndProgram.users.Add(newUser);
            break;

        case "2" or "2)":
            if (UserFileAndProgram.users.Count == 0)
            {
                Console.WriteLine("\n Список пуст! \n");
            }
            for (int i = 0; i < UserFileAndProgram.users.Count; i++)
            {
                Console.WriteLine($" {UserFileAndProgram.users[i].Id} {UserFileAndProgram.users[i].Name} {UserFileAndProgram.users[i].Login} {UserFileAndProgram.users[i].Password}");
            }

            break;

        case "3" or "3)":
            Console.Write("\n Введи Id пользователя для удаления: ");
            int userInputId = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < UserFileAndProgram.users.Count; i++)
            {
                if (UserFileAndProgram.users[i].Id == userInputId)
                {
                    UserFileAndProgram.users.RemoveAt(i);
                    Console.WriteLine(" Пользователь удален!");
                }
            }
            if (UserFileAndProgram.users.Count == 0)
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
    if (hash != null)
    {
        for (int i = 0; i < hash.Length; i++)
        {
            string[] hashArray = hash[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int hashId = Convert.ToInt32(hashArray[0]);
            string hashName = hashArray[1];
            string hashLogin = hashArray[2];
            string hashPassword = hashArray[3];
            User newUser = new User(hashName, hashLogin, hashPassword);
            newUser.Id = hashId;
            UserFileAndProgram.users.Add(newUser);
        }
    }
}

internal static class UserFileAndProgram
{
    internal const string path = @"C:\Users\Admin\Desktop\Cifra digital\ConsoleApp68\userData.txt";
    internal static List<User> users = new List<User>();

    internal static void SaveData(string saveString)
    {
        string[] arr = GetData();
        if (arr == null)
        {
            File.AppendAllText(path, saveString);
        }
        else 
        {
            File.AppendAllText(path, "\n" + saveString);
        }
    }
    internal static string[] GetData()
    {
        string[] fileArray = File.ReadAllLines(path);
        return fileArray;
    }

    internal static IsDataExists isDataExists = (string stringData) =>
    {
        string str;
        return str = stringData ?? throw new Exception("Нет данных");
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
        for (int i = 0; i < UserFileAndProgram.users.Count; i++)
        {
            if (UserFileAndProgram.users[i].Login == Name)
            {
                Console.WriteLine($" Пользователь с логином {Name} уже существует в системе");
                break;
            }
        }
        this.Name = UserFileAndProgram.isDataExists(Name);
        this.Login = UserFileAndProgram.isDataExists(Login);
        this.Password = UserFileAndProgram.isDataExists(Password);
        int count = UserFileAndProgram.users.Count;
        this.Id = count++;
        string saveString = $"{this.Id} {this.Name} {this.Login} {this.Password}";
        UserFileAndProgram.SaveData(saveString);
    }
}