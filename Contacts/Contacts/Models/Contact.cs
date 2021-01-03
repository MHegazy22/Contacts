using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Models
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string Email { get; set; }

        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public Contact() { }
    }
}
