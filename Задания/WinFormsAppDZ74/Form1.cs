namespace WinFormsAppDZ74
{
    public partial class Form1 : Form
    {
        // Да, у формы отсутствует контейнер, поэтому элементы намертво приклеены, но я их уже устал делать, потому что никто не ценит(
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void PathLoader()
        {
            string path = @textBoxPath.Text;
            if (!(string.IsNullOrEmpty(path)))
            {
                if (!(File.Exists(path)))
                {
                    MessageBox.Show(" Файл не найден");
                }
                else
                {
                    string[] fileInformation = File.ReadAllLines(path);
                    foreach (string line in fileInformation) 
                    {
                        textBoxPlan.Text += line + "\r\n";
                    }
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PathLoader();
        }

        private void textBoxPlan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
