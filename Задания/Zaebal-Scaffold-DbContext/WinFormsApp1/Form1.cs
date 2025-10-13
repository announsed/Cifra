using System.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxSourseUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload()
        {
            string path = textBoxSourseUser.Text;
            if (string.IsNullOrEmpty(path))
            {
                using (DBLocal dBLocal = new DBLocal(path))
                {
                    var connection = dBLocal.Database.GetDbConnection();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    int index = path.LastIndexOf('/');
                    string nameUserDataBase = path.Substring(index + 1, path.Length - 3);
                    using (var render = connection.ExecuteReader($"SELECT * FROM {nameUserDataBase}"))
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(render);
                        dataGridViewForDataBase.DataSource = null; dataGridViewForDataBase.DataSource = dataTable;
                        dataGridViewForDataBase.Refresh();
                        MessageBox.Show("Загрузка произошла учпешно!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверное заполнение данных!");
            }
        }
        private void buttonLinkUser_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void textBoxServerLink_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxNameDB_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPassUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void InicilizeConnect()
        {
            string serverLink = textBoxServerLink.Text;
            string nameDB = textBoxNameDB.Text;
            string userId = textBoxUserID.Text;
            string passwordUser = textBoxPassUser.Text;
            if (!String.IsNullOrWhiteSpace(serverLink) && !String.IsNullOrWhiteSpace(nameDB) && !String.IsNullOrWhiteSpace(userId) && !String.IsNullOrWhiteSpace(passwordUser))
            {
                using (DB dB = new DB(serverLink, nameDB, userId, passwordUser))
                {
                    var connection = dB.Database.GetDbConnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (var render = connection.ExecuteReader($"SELECT * FROM {nameDB}"))
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(render);
                        dataGridViewForDataBase.DataSource = null; dataGridViewForDataBase.DataSource = dataTable;
                        dataGridViewForDataBase.Refresh();
                        MessageBox.Show("Загрузка произошла учпешно!");
                    }
                }
                ;
            }
            else
            {
                MessageBox.Show("Неверное заполнение данных!");
            }
        }

        private void buttonUserInputDBServer_Click(object sender, EventArgs e)
        {
            InicilizeConnect();
        }

        private void dataGridViewForDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async Task TimeAsync()
        {
            long second = 0;
            while (true)
            {
                this.Text = $"Время с момента запуска: {second} с. \t\t\t\t\t Текущее время: {DateTime.Now:T}";
                await Task.Delay(1000);
                second++;
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await TimeAsync();
        }
    }
}
