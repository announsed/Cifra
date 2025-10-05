using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using OfficeOpenXml;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.License.SetNonCommercialPersonal(" PersonalNotLicenseCommerrcial");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    // Реализация класса User по заданию
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
    }


    // Реализация статического класса для регистрации юзеров
    public static class UserRegistration
    {
        // Метод для регистрации пользвателей с проверками уникальности по нику и емайл
        public static void RegisterUser(User newUser)
        {
            if (StaticListUsers.users.Count == 0)
            {
                StaticListUsers.users.Add(newUser);
                MessageBox.Show($" Пользователь зарегистрирован");
            }
            else
            {
                bool privateInfoContinue = false;
                for (int i = 0; i < StaticListUsers.users.Count; i++)
                {
                    if (StaticListUsers.users[i].UserName == newUser.UserName)
                    {
                        privateInfoContinue = true;
                        MessageBox.Show($" Пользователь с именем {newUser.UserName} уже существует");
                    }
                    else if (StaticListUsers.users[i].Email == newUser.Email)
                    {
                        privateInfoContinue = true;
                        MessageBox.Show($" Пользователь c mail {newUser.Email} уже существует");
                    }
                }
                if (privateInfoContinue != true)
                {
                    StaticListUsers.users.Add(newUser);
                    MessageBox.Show($" Пользователь зарегистрирован");
                }
            }
        }

        // Для сериализации юзеров из листа по заданию, с опциями для правильного отображения
        public static string SerializeUserToJson(List<User> users)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true, // для повышения читаемости
                IncludeFields = true
            };
            string fileJsonSerialaze = JsonSerializer.Serialize(users, options);
            return fileJsonSerialaze;
        }
    }


    // Статический класс с реализаций листа с юзерами для хранения зарегестрированных пользователей
    public static class StaticListUsers
    {
        public static List<User> users = new List<User>();
    }

    // Класс для проверки на пробелы и null
    public static class IsNullAndAllSpaces
    {
        public static bool IsNullOrEmptyOrAllSpaces(string str)
        {
            if (str == null || str.Length == 0)
            {
                return true;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsWhiteSpace(str[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }

    // (EPPLus)  Создание книги, путь и имя для сохранения файла
    public static class StaticExcelPackegeBook
    {
        public static ExcelPackage newBook = new ExcelPackage();
        public static string PathInBook(string path)
        {
            return path;
        }
        public static string NameFailToSave(string pathInBook, string nameFile)
        {
            return pathInBook + @"\" + nameFile + ".xlsx";
        }
        public static void UserInputNameToListInBook(string nameList, out ExcelWorksheet excelWorksheet)
        {
            excelWorksheet = null;
            if (newBook.Workbook.Worksheets[nameList] == null)
            {
                newBook.Workbook.Worksheets.Add(nameList);
                excelWorksheet = newBook.Workbook.Worksheets[nameList];
            }
            else
            {
                MessageBox.Show($" Файл с именем: {nameList} не может быть создан");
            }
        }
        public static void ConvertListToExcelAndFinalFileSave(ExcelWorksheet excelWorksheet, string fullPathFileSave)
        {
            for (int i = 0; i < StaticListUsers.users.Count; i++)
            {
                string[] hashUser =
                [
                    StaticListUsers.users[i].Id.ToString(),
                    StaticListUsers.users[i].UserName,
                    StaticListUsers.users[i].FirstName,
                    StaticListUsers.users[i].SecondName,
                    StaticListUsers.users[i].Email,
                    StaticListUsers.users[i].Password,
                    StaticListUsers.users[i].RegistrationDate.ToString(),
                    StaticListUsers.users[i].BirthDate.ToString(),
                ];
                for (int j = 0; j < hashUser.Length; j++)
                {
                    excelWorksheet.Cells[i + 1, j + 1].AutoFitColumns();
                    excelWorksheet.Cells[i + 1, j + 1].Value = hashUser[j];
                }
            }
            newBook.SaveAs(new FileInfo(fullPathFileSave));
        }
    }

    // CSV 
    public static class StaticPackegeCSVFile
    {
        public static string PathInBook(string path)
        {
            return path;
        }
        public static string NameFailToSave(string pathInBook, string nameFile)
        {
            return pathInBook + @"\" + nameFile + ".csv";
        }

        public static CsvWriter StreamWriterAndCSVWriter(string path)
        {
            return new CsvWriter(new StreamWriter(path), new
 CsvConfiguration (CultureInfo.InvariantCulture));
        }

        public static CsvReader StreamReaderAndCSVReader(string path) 
        {
            return new CsvReader(new StreamReader(path), new CsvConfiguration (CultureInfo.InvariantCulture));
        }
    }

    public static class UploadCSV 
    {
        public static OpenFileDialog OpenFileCSV() 
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл для загрузки";
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.InitialDirectory = directoryPath;
<<<<<<< HEAD
            openFileDialog.Filter = "Файл CSV(.csv)|*.csv";
=======
            openFileDialog.Filter = "Файл(.csv)";
>>>>>>> 9bd631a69a24595c19541da667ffed458bd3b011
            openFileDialog.RestoreDirectory = true;
            return openFileDialog;
        }

        public static string ShowDialog(OpenFileDialog openFileDialog) 
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string userFilePath = openFileDialog.FileName;
                return userFilePath;
            }
            return null;
        }
    }
}