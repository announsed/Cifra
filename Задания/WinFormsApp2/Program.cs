using System.ComponentModel;
using OfficeOpenXml;

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.License.SetNonCommercialPersonal("Персональная не коммерческая лицензия");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    // хочу, что-бы доступ к свойствам класса, был реализован через интерфейс  (не используется, для дальнейших апдейтов)
    public interface IGetContact
    {
        [DisplayName("Имя контакта")]
        string Name { get; }

        [DisplayName("Адрес")]
        string Address { get; }

        [DisplayName("Номер телефона")]
        string NumberPhone { get; }

        [DisplayName("Электронный адрес")]
        string Email { get; }

    }

    
    class Contact : IGetContact
    {
        private string _name;
        private string _address;
        private string _numberPhone;
        private string _email;

        public Contact(string name, string address, string numberPhone, string email)
        {
            _name = name;
            _address = address;
            _numberPhone = numberPhone;
            _email = email;
        }

        string IGetContact.Name { get { return _name; } }
        string IGetContact.Address { get { return _address; } }
        string IGetContact.NumberPhone { get { return _numberPhone; } }
        string IGetContact.Email { get { return _email; } }
    }


    // по факту почти бесполезная прослойка
    public static class ListContacts
    { 
        internal static List<Contact> contacts = new List<Contact>(); 
    }
}