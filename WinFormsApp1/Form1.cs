using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox1.Text != null || textBox2.Text != "" || textBox2.Text != null || textBox5.Text != "" || textBox5.Text != null || textBox3.Text != "" || textBox3.Text != null || textBox4.Text != "" || textBox4.Text != null)
            {
                if (textBox3.Text.Contains('@'))
                {
                    User user = new User();
                    user.Id = StaticListUsers.users.Count + 1;
                    user.UserName = textBox1.Text;
                    user.FirstName = textBox2.Text;
                    user.SecondName = textBox5.Text;
                    user.Email = textBox3.Text;
                    user.Password = textBox4.Text;
                    user.RegistrationDate = DateTime.Now;
                    user.BirthDate = dateTimePicker1.Value;
                    UserRegistration.RegisterUser(user);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show($" Пользователь добавлен");
                }
                else 
                {
                    MessageBox.Show($" Адрес {textBox3.Text} некорректен");
                }
            }
            else
            {
                MessageBox.Show(" Некорректный ввод данных");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FileNameToSerialaz = Interaction.InputBox(" Введите имя файла");
            string path = Interaction.InputBox(" Введите путь сохранения файла (можно ничего не вводить, тогда он останется по умолчании в корнейвой папке)");
            if (FileNameToSerialaz != null || FileNameToSerialaz != "")
            {
                string stringJson = UserRegistration.SerializeUserToJson(StaticListUsers.users);
                if (path == null)
                {
                    File.AppendAllText(FileNameToSerialaz + ".json", stringJson);
                }
                else
                {
                    File.AppendAllText(@path + @"\" + FileNameToSerialaz + ".json", stringJson);
                }
                MessageBox.Show(" Сериализация выполнена");
            }
            else
            {
                MessageBox.Show(" Имя файла введено некорректно");
            }
        }
    }
}
