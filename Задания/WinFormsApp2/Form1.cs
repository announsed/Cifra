using Microsoft.VisualBasic;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void AddContactAsync() 
        {
            await Task.Run(() => { Application.Run(new Form2AddContact()); });

            dataGridView1.DataSource = ListContacts.contacts;
            dataGridView1.Refresh();
        }
        private void button1AddContact_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(obj => { AddContactAsync(); });
        }


        private void DeleteByNameToContact() 
        {
            string userUnputName = Interaction.InputBox("Введите имя: ", "Удаление по имени контакта");
            if (!(String.IsNullOrWhiteSpace(userUnputName)))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == userUnputName)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
            else 
            {
                MessageBox.Show(" Не может быть удалено");
            }
        }
        private void button1DeleteInNameContact_Click(object sender, EventArgs e)
        {
            DeleteByNameToContact();
        }


        private void RecoveryCells(EventArgs eventArgs) 
        {
            if (dataGridView1.CurrentCell != null) 
            {
                string recovery = Interaction.InputBox($"Изменить значение {dataGridView1.CurrentCell.Value} на: ", "Изменить значение ячейки");
                if (!(String.IsNullOrWhiteSpace(recovery)))
                {
                    dataGridView1.CurrentCell.Value = recovery;
                }
                else 
                {
                    MessageBox.Show(" Значение не может быть установлено");
                }

            }
        }
        private void button1Recovery_Click(object sender, EventArgs e)
        {
            RecoveryCells(e);
        }
    }
}
