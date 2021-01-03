using Contacts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                FirstName = firstNameEntry.Text,
                LasttName = lastNameEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Email = emailEntry.Text,
                Address = addressEntry.Text
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Contact>();
                int row = conn.Insert(contact);
            }
        }
    }
}
