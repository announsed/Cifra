using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2AddContact : Form
    {
        public Form2AddContact()
        {
            InitializeComponent();
        }

        private void Form2AddContact_Load(object sender, EventArgs e)
        {

        }

        private void AddNewContact() 
        {
            if (!(String.IsNullOrWhiteSpace(textBoxNameContact.Text)) && !(String.IsNullOrWhiteSpace(textBoxAddress.Text)) && !(String.IsNullOrWhiteSpace(textBoxNumberPhone.Text)) && !(String.IsNullOrWhiteSpace(textBoxEMail.Text)))
            {
                Contact newContact = new Contact(textBoxNameContact.Text, textBoxAddress.Text, textBoxNumberPhone.Text, textBoxEMail.Text);
                ListContacts.contacts.Add(newContact);
            }
            else 
            {
                MessageBox.Show(" Данные не могут быть добавлены!");
            }
        }
        private void buttonContinueOK_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        private void textBoxNameContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEMail_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
