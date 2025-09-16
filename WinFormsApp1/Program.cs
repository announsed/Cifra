using System;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }


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

    public static class UserRegistration
    {
        public static void RegisterUser(User newUser)
        {
            for (int i = 0; i < StaticListUsers.users.Count; i++)
            {
                bool privateInfoContinue = false;
                if (StaticListUsers.users[i].UserName != newUser.UserName)
                {
                    privateInfoContinue = true;
                }
                else 
                {
                    privateInfoContinue = false;
                    MessageBox.Show($" Пользователь c именем {newUser.UserName} уже существует");
                }
                if (StaticListUsers.users[i].Email != newUser.Email) 
                {
                    privateInfoContinue = true;
                }
                else
                {
                    privateInfoContinue = false;
                    MessageBox.Show($" Пользователь c mail {newUser.Email} уже существует");
                }
                if (privateInfoContinue == true) 
                {
                    StaticListUsers.users.Add(newUser);
                }
            }
        }
        public static string SerializeUserToJson(List<User> users)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true, // Для читаемости, необязательно
                IncludeFields = true
            };
            string fileJsonSerialaze = JsonSerializer.Serialize(users, options);
            return fileJsonSerialaze;
        }
    }

    public static class StaticListUsers
    {
        public static List<User> users = new List<User>();
    }
}