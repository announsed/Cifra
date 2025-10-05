namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task LoadBackgroundImageAsync(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync(imageUrl);


                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        this.BackgroundImage = new Bitmap(stream);
                        this.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
        private async void panel1_Paint(object sender, PaintEventArgs e)
        {
           await LoadBackgroundImageAsync(@"https://i.pinimg.com/originals/5e/24/1b/5e241b2c16d1c6b7153a93f68abb1f24.jpg");
        }
    }
}
