using System.Collections.Generic;
using Microsoft.VisualBasic;
using OfficeOpenXml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для проверки, добавления валидных юзеров в статический лист, а так-же очищения полей
        private void RegistrationUser()
        {
            if (textBox1.Text != "" || textBox1.Text != null || textBox2.Text != "" || textBox2.Text != null || textBox5.Text != "" || textBox5.Text != null || textBox3.Text != "" || textBox3.Text != null || textBox4.Text != "" || textBox4.Text != null)
            {
                if (textBox3.Text.Contains('@'))
                {
                    //button1.Enabled = true;
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
                }
                else
                {
                    MessageBox.Show($" Данный {textBox3.Text} не подходит");
                }
            }
            else
            {
                MessageBox.Show(" Ошибка валидации данных");
            }
        }

        // Для проверки изменений в листе для сериализации
        private int hashSerializationInList = StaticListUsers.users.Count;

        // Метод с проверками для сериализации листа
        private void PerformSerialization()
        {
            if (hashSerializationInList < StaticListUsers.users.Count)
            {
                //button2.Enabled = true;

                string FileNameToSerialaz = Interaction.InputBox(" Введите имя файла", "Имя файла");
                string path = Interaction.InputBox(" Укажите путь, где будет сохранен файл (если не указывать, то файл будет сохранен в директории проекта)");
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
                    hashSerializationInList = StaticListUsers.users.Count;
                }
                else
                {
                    MessageBox.Show(" Ошибка имени файла");
                }
            }
        }

        // Для проверки изменений в листе для конвертации и выгрузки в Excel файл
        int hashConvertListToExcel = StaticListUsers.users.Count;

        // Метод для выгрузки листа с юзерами в таблицу с графическим отображением
        private bool UploadToTheTableExcel()
        {
            bool upload = false;
            if (hashConvertListToExcel <= StaticListUsers.users.Count)
            {
                //button3.Enabled = true;
                string filePuthInputUser = StaticExcelPackegeBook.PathInBook(Interaction.InputBox(" Введите путь сохранения файла", "Путь файла"));
                if (!(IsNullAndAllSpaces.IsNullOrEmptyOrAllSpaces(filePuthInputUser)))
                {
                    string userInputFileName = Interaction.InputBox(" Введите имя файла ", "Имя файла");
                    if (!(IsNullAndAllSpaces.IsNullOrEmptyOrAllSpaces(userInputFileName)))
                    {
                        string fileFullNameFinal = StaticExcelPackegeBook.NameFailToSave(filePuthInputUser, userInputFileName);

                        string userInputListName = Interaction.InputBox(" Введите имя для листа (если ничего не ввести, то именем по умолчанию будет Лист 1)", "Имя листа");
                        if (!(IsNullAndAllSpaces.IsNullOrEmptyOrAllSpaces(userInputListName)))
                        {
                            StaticExcelPackegeBook.UserInputNameToListInBook(userInputListName, out ExcelWorksheet excelWorksheet);
                            StaticExcelPackegeBook.ConvertListToExcelAndFinalFileSave(excelWorksheet, fileFullNameFinal);

                            MessageBox.Show($" Файл успешно сохранен по пути: {filePuthInputUser} с именем: {userInputFileName}");
                            hashConvertListToExcel = StaticListUsers.users.Count;
                            upload = true;
                        }
                        else
                        {
                            StaticExcelPackegeBook.UserInputNameToListInBook("Лист 1", out ExcelWorksheet excelWorksheet);
                            StaticExcelPackegeBook.ConvertListToExcelAndFinalFileSave(excelWorksheet, filePuthInputUser);
                            MessageBox.Show($" Файл успешно сохранен по пути: {filePuthInputUser} с именем: Лист 1");
                            hashConvertListToExcel = StaticListUsers.users.Count;
                            upload = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Имя файла не может быть пустым ");
                    }
                }
                else
                {
                    MessageBox.Show(" Путь файла не может быть пустым ");
                }
            }
            else
            {
                MessageBox.Show(" Ничего не было изменено! ");
            }
            return upload;
        }

        // Кнопка для регистрации пользователей, с вкл/выкл статусом
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationUser();
        }

        // Кнопка для сериализации листа юзеров в файл, с вкл/выкл  статусом
        private void button2_Click(object sender, EventArgs e)
        {
            PerformSerialization();
        }

        // Кнопка для выгрузки листа в таблицу exel с графическим отображением в программе
        private void button3_Click(object sender, EventArgs e)
        {
            //if (UploadToTheTable()) 
            //{
            ClearUserInGridTable();
            UploadUserInGridTable();
            //}
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


        // Клендарь с выбором даты
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Для отображения в форме таблицы
        private void UploadUserInGridTable()
        {
            //for (int i = 0; i < StaticListUsers.users.Count; i++) 
            //{
            //    if (StaticListUsers.users[i].Id.ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString() && StaticListUsers.users[i].UserName.ToString() == dataGridView1.Rows[i].Cells[2].Value.ToString() && StaticListUsers.users[i].FirstName.ToString() == dataGridView1.Rows[i].Cells[3].Value.ToString() && StaticListUsers.users[i].SecondName.ToString() == dataGridView1.Rows[i].Cells[4].Value.ToString() && StaticListUsers.users[i].Email.ToString() == dataGridView1.Rows[i].Cells[5].Value.ToString() && StaticListUsers.users[i].Password.ToString() == dataGridView1.Rows[i].Cells[6].Value.ToString() && StaticListUsers.users[i].RegistrationDate.ToString() == dataGridView1.Rows[i].Cells[7].Value.ToString() && StaticListUsers.users[i].RegistrationDate.ToString() == dataGridView1.Rows[i].Cells[8].Value.ToString() && StaticListUsers.users[i].BirthDate.ToString() == dataGridView1.Rows[i].Cells[9].Value.ToString())
            //    {
            //        continue;
            //    }
            //    else 
            //    {
            //        dataGridView1.Rows.Add(StaticListUsers.users[i].Id, StaticListUsers.users[i].UserName, StaticListUsers.users[i].FirstName, StaticListUsers.users[i].SecondName, StaticListUsers.users[i].Email, StaticListUsers.users[i].Password, StaticListUsers.users[i].RegistrationDate, StaticListUsers.users[i].BirthDate);
            //    }
            //}


            foreach (User user in StaticListUsers.users)
            {
                dataGridView1.Rows.Add(user.Id, user.UserName, user.FirstName, user.SecondName, user.Email, user.Password, user.RegistrationDate, user.BirthDate);
            }
        }

        // Метод для очистки таблицы
        private void ClearUserInGridTable()
        {
            dataGridView1.Rows.Clear();
        }


        // Выгрузить в Excel файл данные из List Юзеров
        private void button4_Click(object sender, EventArgs e)
        {
            UploadToTheTableExcel();
        }

        private void UploadToTheTableCSV()
        {
            string filePuthInputUser = StaticPackegeCSVFile.PathInBook(Interaction.InputBox(" Введите путь сохранения файла", "Путь файла"));
            if (!(IsNullAndAllSpaces.IsNullOrEmptyOrAllSpaces(filePuthInputUser)))
            {
                string userInputFileName = Interaction.InputBox(" Введите имя файла ", "Имя файла");
                if (!(IsNullAndAllSpaces.IsNullOrEmptyOrAllSpaces(userInputFileName)))
                {
                    string fileFullNameFinal = StaticPackegeCSVFile.NameFailToSave(filePuthInputUser, userInputFileName);
                    using (var writerCSV = StaticPackegeCSVFile.StreamWriterAndCSVWriter(fileFullNameFinal))
                    {
                        writerCSV.WriteRecords(StaticListUsers.users);
                    }
                    MessageBox.Show($" Файл успешно сохранен по пути: {filePuthInputUser} с именем: {userInputFileName}");
                }
                else
                {
                    MessageBox.Show(" Имя файла не может быть пустым!");
                }
            }
            else
            {
                MessageBox.Show(" Путь файла не может быть пустым!");
            }
        }
        // Выгрузка в CSV файл
        private void button5_Click(object sender, EventArgs e)
        {
            UploadToTheTableCSV();
        }

        private void UnUploadCSV() 
        {
            var openfile = UploadCSV.OpenFileCSV();
            string usserPath = UploadCSV.ShowDialog(openfile);
            if (usserPath != null) 
            {
                StaticListUsers.users.AddRange((StaticPackegeCSVFile.StreamReaderAndCSVReader(usserPath)).GetRecords(User).ToList());
                MessageBox.Show(" Данные загружены");
            }
        }
        // Загрузка из CSV файла
        private void UnIploadInCSV_Click(object sender, EventArgs e)
        {
            UnUploadCSV();
        }
    }
}
