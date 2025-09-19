namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<User> _users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            AddUser(textBoxUserName.Text, textBoxUserSurname.Text, textBoxUserAge.Text);

        }
        private void AddUser(string name, string surName, string age)
        {
            _users.Add(new User(name, surName, int.Parse(age)));
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxUserSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void UploadListToGridBTN_Click(object sender, EventArgs e)
        {
            UploadUser();
        }
        private void UploadUser()
        {
            foreach (User user in _users)
            {
                dataGridView1.Rows.Add(user.Name, user.SurName, user.Age);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
