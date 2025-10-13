using Microsoft.EntityFrameworkCore;

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

    public partial class DBLocal : DbContext
    {
        private string _path;
        public DBLocal(string path) 
        {
            _path = @path;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source ={_path}");
        }
    }

    public partial class DB : DbContext
    {
        private string _server;
        private string _database;
        private string _UserId;
        private string _password;


        public DB(string server, string database, string userId, string password)
        {
            _server = server;
            _database = database;
            _UserId = userId;
            _password = password;
        }
        public DB(DbContextOptions<DB> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={_server};Database={_database};User Id={_UserId};Password={_password};TrustServerCertificate=True;");
        }
    }
}