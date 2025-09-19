using System.ComponentModel;

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
            Thread thread1 = new Thread(() => { Application.Run(new Form1()); });
            Thread thread2 = new Thread(() => { Application.Run(new Form2()); });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public User(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }
    }


    class Person
    {
        [DisplayName("Имя пользователя")]
        public string Name { get; set; }


        [DisplayName("Возраст")]
        public int Age { get; set; }


        [DisplayName("Рост")]
        public double Height { get; set; }


        [DisplayName("Вес")]
        public double Weight { get; set; }

        public Person(string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }

}