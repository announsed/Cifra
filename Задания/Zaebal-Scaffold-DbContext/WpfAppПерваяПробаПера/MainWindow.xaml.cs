using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppПерваяПробаПера
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase dataBase = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxNameUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxLastNameUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxAgeUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddUser(DataBase dataBase)
        {
            string nameUser = "";
            string lastNameUser = "";
            uint ageUser = 0;
            if (!(String.IsNullOrWhiteSpace(TextBoxNameUser.Text)))
            {
                nameUser = TextBoxNameUser.Text;
            }
            else
            {
                MessageBox.Show("Введите корректное имя пользователя!");
            }
            if (!(String.IsNullOrWhiteSpace(TextBoxLastNameUser.Text)))
            {
                lastNameUser = TextBoxLastNameUser.Text;
            }
            else
            {
                MessageBox.Show("Введите корректное фамилию пользователя!");
            }
            if (uint.TryParse(TextBoxAgeUser.Text, out uint age) && age != 0)
            {
                ageUser = age;
            }
            else
            {
                MessageBox.Show("Введите корректный возраст пользователя!");
            }
            if (nameUser != "" && lastNameUser != "" && ageUser != 0)
            {
                dataBase.Users.Add(new User() { Name = nameUser, LastName = lastNameUser, Age = ageUser });
                var lastUserInDataBase = dataBase.Users
                         .OrderByDescending(u => u.Id)
                         .FirstOrDefault();
                TelegrammBot.TelegrammMessage($"Пользователь:\n Id: {lastUserInDataBase.Id}\n Имя: {lastUserInDataBase.Name}\n Фамилия: {lastUserInDataBase.LastName}\n Возраст: {lastUserInDataBase.Age}\n Успешно добавлен в базу данных от:\n\n\n{NetworkPositionInfo.GetLocalIPAddresses}\n{NetworkPositionInfo.GetSystemTimeLocationInfo}\n{NetworkPositionInfo.GetComputerInfo}");
                MessageBox.Show($"Пользователь: {nameUser} {lastNameUser} {ageUser} добавлен в базу данных");
            }
        }

        private void ButtonRegistrationUser_Click(object sender, RoutedEventArgs e)
        {
            AddUser(dataBase);
        }

        private async Task InformationForm()
        {
            string infoBorder = "Формошка Регистрации Юзверей (Зарегистрировано пользователей = ";
            await Task.Run(() => 
            {
                while (true)
                {
                    WindowForm.Name = infoBorder +$"{dataBase.Users.Count()} )";
                    TimeSpan.FromMilliseconds(1000);
                }
            });
        }

        private async void WindowForm_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            await InformationForm();
        }


        private static void ContextCliced() 
        {
            long i = 0;
            i += 1;
            Application.Current.Dispatcher.Invoke(() =>
            {
                
            });
        }


        private void ButtonTap_Click(object sender, RoutedEventArgs e)
        {
             
        }
    }
}